using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPatternExample
{

    // Interfaz del Mediator
    public interface IChatMediator
    {
        void SendMessage(string message, ChatUser user);
        void AddUser(ChatUser user);
    }
}
