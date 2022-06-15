using CompositeDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern.Infra
{
    public class Composite : ICustomComponent
    {
        public string Name { get; set; }
        List<ICustomComponent> components = new List<ICustomComponent>();
        public Composite(string name)
        {
            this.Name = name;
        }
        public void AddComponent(ICustomComponent component)
        {
            components.Add(component);
        }


        public decimal CalculatePrice()
        {
            decimal TotalPrice = 0;
            foreach (var item in components)
            {
                TotalPrice += item.CalculatePrice();
            }
            return TotalPrice;
        }
    }
}
