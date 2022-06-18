using CommandPattern.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Infra.Commands
{
    public class DeleteCommand : Command
    {
        private string key;
        public DeleteCommand(string key, DataReceiver receiver) : base(receiver)
        {
            this.key = key;
        }

        public override void Execute()
        {
            receiver.Delete(key);
        }
    }
}
