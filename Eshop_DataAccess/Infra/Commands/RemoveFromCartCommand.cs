using Eshop_DataAccess.Interface;
using Eshop_DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop_DataAccess.Infra.Commands
{
    public class RemoveFromCartCommand : ICommand
    {
        private readonly IShoppingCartRepository shoppingCartRepository;
        private readonly IProductRepository productRepository;
        private readonly Product product;

        public RemoveFromCartCommand(IShoppingCartRepository shoppingCartRepository,
            IProductRepository productRepository,
            Product product)
        {
            this.shoppingCartRepository = shoppingCartRepository;
            this.productRepository = productRepository;
            this.product = product;
        }

        public bool CanExecute()
        {
            if (product == null) return false;

            return shoppingCartRepository.Get(product.ArticleId).Quantity > 0;
        }

        public void Execute()
        {
            if (product == null) return;

            var lineItem = shoppingCartRepository.Get(product.ArticleId);

            productRepository.IncreaseStockBy(product.ArticleId, lineItem.Quantity);

            shoppingCartRepository.RemoveAll(product.ArticleId);
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
