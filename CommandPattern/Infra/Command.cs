using CommandPattern.Data;
using CommandPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Infra
{
    public abstract class Command : ICommand
    {
        protected DataReceiver receiver;
        public Command(DataReceiver receiver)
        {
            this.receiver = receiver;
        }

        public abstract void Execute();
    }
}
