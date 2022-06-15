using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern.Interface
{
    public interface ICustomComponent
    {
        void AddComponent(ICustomComponent component);

        decimal CalculatePrice();
    }
}
