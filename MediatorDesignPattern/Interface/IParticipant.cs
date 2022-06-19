using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.Interface
{
    public interface IParticipant
    {
        void SendCommand(string receiver, string command);
        void ReceiveCommand(string sender, string command);
    }
}
