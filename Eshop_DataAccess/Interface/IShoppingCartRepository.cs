using Eshop_DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop_DataAccess.Interface
{
    public interface IShoppingCartRepository
    {
        (Product Product, int Quantity) Get(string articleId);
        IEnumerable<(Product Product, int Quantity)> All();
        void Add(Product product);
        void RemoveAll(string articleId);
        void IncreaseQuantity(string articleId);
        void DecraseQuantity(string articleId);
    }
}
