﻿using Eshop_DataAccess.Infra.Enums;
using Eshop_DataAccess.Interface;
using Eshop_DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop_DataAccess.Infra.Commands
{
    public class ChangeQuantityCommand : ICommand
    {

        private readonly Operation operation;
        private readonly IShoppingCartRepository shoppingCartRepository;
        private readonly IProductRepository productRepository;
        private readonly Product product;

        public ChangeQuantityCommand(Operation operation,
            IShoppingCartRepository shoppingCartRepository,
            IProductRepository productRepository,
            Product product)
        {
            this.operation = operation;
            this.shoppingCartRepository = shoppingCartRepository;
            this.productRepository = productRepository;
            this.product = product;
        }

        public void Execute()
        {
            switch (operation)
            {
                case Operation.Decrease:
                    productRepository.IncreaseStockBy(product.ArticleId, 1);
                    shoppingCartRepository.DecraseQuantity(product.ArticleId);
                    break;
                case Operation.Increase:
                    productRepository.DecreaseStockBy(product.ArticleId, 1);
                    shoppingCartRepository.IncreaseQuantity(product.ArticleId);
                    break;
            }
        }

        public bool CanExecute()
        {
            switch (operation)
            {
                case Operation.Decrease:
                    return shoppingCartRepository.Get(product.ArticleId).Quantity != 0;
                case Operation.Increase:
                    return (productRepository.GetStockFor(product.ArticleId) - 1) >= 0;
            }

            return false;
        }

        public void Undo()
        {
            switch (operation)
            {
                case Operation.Decrease:
                    productRepository.DecreaseStockBy(product.ArticleId, 1);
                    shoppingCartRepository.IncreaseQuantity(product.ArticleId);
                    break;
                case Operation.Increase:
                    productRepository.IncreaseStockBy(product.ArticleId, 1);
                    shoppingCartRepository.DecraseQuantity(product.ArticleId);
                    break;
            }
        }
    }
}

