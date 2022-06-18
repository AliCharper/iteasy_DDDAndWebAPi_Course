using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop_DataAccess.Interface
{
    public interface ICommand
    {
        void Execute();
        bool CanExecute();
        void Undo();
    }
}
