using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPatternExample
{
    // Implementación del Mediator
    public class ChatMediator : IChatMediator
    {
        public void SendMessage(string message, ChatUser user)
        {
            // Implementa la lógica para enviar mensajes a todos los usuarios, excepto al remitente
            foreach (var u in users)
            {
                if (u != user)
                {
                    u.ReceiveMessage($"{user.GetName()}: {message}");
                }
            }
        }

        private List<ChatUser> users = new List<ChatUser>();

        public void AddUser(ChatUser user)
        {
            users.Add(user);
        }
    }
}