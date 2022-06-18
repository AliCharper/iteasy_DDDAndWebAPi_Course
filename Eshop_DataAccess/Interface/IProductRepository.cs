using Eshop_DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop_DataAccess.Interface
{
    public interface IProductRepository
    {
        Product FindBy(string articleId);
        int GetStockFor(string articleId);
        IEnumerable<Product> All();
        void DecreaseStockBy(string articleId, int amount);
        void IncreaseStockBy(string articleId, int amount);
    }
}
