using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPatternExample
{



    // Implementación del Usuario
    public class ChatUser
    {
        private string name;
        private IChatMediator mediator;

        public ChatUser(string name, IChatMediator mediator)
        {
            this.name = name;
            this.mediator = mediator;
        }

        public void SendMessage(string message)
        {
            Console.WriteLine($"{name} envía el mensaje: {message}");
            mediator.SendMessage(message, this);
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"{name} recibe el mensaje: {message}");
        }

        public string GetName()
        {
            return name;
        }
    }
}
