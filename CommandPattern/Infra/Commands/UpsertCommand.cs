using CommandPattern.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Infra.Commands
{
    public class UpsertCommand : Command
    {
        private string key;
        private string value;
        public UpsertCommand(string key, string value, DataReceiver receiver) : base(receiver)
        {
            this.key = key;
            this.value = value;
        }

        public override void Execute()
        {
            receiver.Upsert(key, value);
        }
    }
}
