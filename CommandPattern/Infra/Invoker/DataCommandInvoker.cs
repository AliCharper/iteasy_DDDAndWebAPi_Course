using CommandPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Infra.Invoker
{
    public class DataCommandInvoker
    {
        private ICommand? command;

        public void SetCommand(ICommand command)
        {
            this.command = command;
            Console.WriteLine($"Command {command.GetType()}");
        }

        public void ExecuteCommand()
        {
            command?.Execute();
        }
    }
}
