using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.Interface
{
    public interface IMediator
    {
        void Register(string key, IParticipant participant);
        void SendCommand(string receiver, string sender, string command);
    }
}
