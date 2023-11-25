using MediatorPatternExample;

class Program
{
    static void Main()
    {
        // Crea el Mediator
        IChatMediator chatMediator = new ChatMediator();

        // Crea usuarios y agrégales al Mediator
        ChatUser user1 = new ChatUser("Usuario1", chatMediator);
        ChatUser user2 = new ChatUser("Usuario2", chatMediator);
        ChatUser user3 = new ChatUser("Usuario3", chatMediator);

        chatMediator.AddUser(user1);
        chatMediator.AddUser(user2);
        chatMediator.AddUser(user3);

        // Simula el envío de mensajes
        user1.SendMessage("¡Hola a todos!");
        user2.SendMessage("¡Hola Usuario1!");
    }
}
