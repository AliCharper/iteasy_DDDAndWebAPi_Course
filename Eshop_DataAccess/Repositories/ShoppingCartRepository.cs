﻿using Eshop_DataAccess.Interface;
using Eshop_DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop_DataAccess.Repositories
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        public Dictionary<string, (Product Product, int Quantity)> LineItems = new Dictionary<string, (Product Product, int Quantity)>();

        public IEnumerable<(Product Product, int Quantity)> All()
        {
            return LineItems.Values;
        }

        public (Product Product, int Quantity) Get(string articleId)
        {
            if (LineItems.ContainsKey(articleId))
            {
                return LineItems[articleId];
            }

            return (default, default);
        }

        public void Add(Product product)
        {
            if (LineItems.ContainsKey(product.ArticleId))
            {
                IncreaseQuantity(product.ArticleId);
            }
            else
            {
                LineItems[product.ArticleId] = (product, 1);
            }
        }

        public void DecraseQuantity(string articleId)
        {
            if (LineItems.ContainsKey(articleId))
            {
                var lineItem = LineItems[articleId];

                if (lineItem.Quantity == 1)
                {
                    LineItems.Remove(articleId);
                }
                else
                {
                    LineItems[articleId] = (lineItem.Product, lineItem.Quantity - 1);
                }
            }
            else
            {
                throw new KeyNotFoundException($"Product with article id {articleId} not in cart, please add first");
            }
        }

        public void IncreaseQuantity(string articleId)
        {
            if (LineItems.ContainsKey(articleId))
            {
                var lineItem = LineItems[articleId];
                LineItems[articleId] = (lineItem.Product, lineItem.Quantity + 1);
            }
            else
            {
                throw new KeyNotFoundException($"Product with article id {articleId} not in cart, please add first");
            }
        }

        public void RemoveAll(string articleId)
        {
            LineItems.Remove(articleId);
        }
    }
}
