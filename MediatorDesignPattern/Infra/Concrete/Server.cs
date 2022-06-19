using MediatorDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.Infra.Concrete
{
    public class Server : Participant
    {
        public Server(string key, IMediator mediator) : base(key, mediator)
        {
        }

        public override void SendCommand(string receiver, string command)
        {
            Console.WriteLine($"Server has issued {command} command to {receiver}.");
            base.SendCommand(receiver, command);
        }

        public override void ReceiveCommand(string sender, string command)
        {
            Console.Write($"Server {key} received a command. ");
            base.ReceiveCommand(sender, command);
        }
    }
}
