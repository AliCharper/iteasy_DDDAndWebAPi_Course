using CompositeDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern.Infra
{
    public class Leaf : ICustomComponent
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public Leaf(string name, int price)
        {
            this.Price = price;
            this.Name = name;
        }
        public decimal CalculatePrice()
        {
            return Price;
        }

        public void AddComponent(ICustomComponent component)
        {
            throw new NotImplementedException();
        }
    }
}
