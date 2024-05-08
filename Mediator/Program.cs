namespace Mediator;

class Program
{
    static void Main(string[] args)
    {
        ChatMediatorImpl chatroom = new ChatMediatorImpl();

        UserImpl user1 = new UserImpl("Timo", chatroom);
        UserImpl user2 = new UserImpl("Cherian", chatroom);
        UserImpl user3 = new UserImpl("Alina", chatroom);
        UserImpl user4 = new UserImpl("Anna", chatroom);
        UserImpl user5 = new UserImpl("Kristina", chatroom);

        chatroom.AddUser(user1);
        chatroom.AddUser(user2);
        chatroom.AddUser(user3);
        chatroom.AddUser(user4);
        

        user3.SendMessage("Hello, everyone!");  

        chatroom.AddUser(user5);
        user5.SendMessage("hi");
        user5.SendPrivateMessage("hi", user2);

        Console.ReadKey();
    }
}

//IChatMediator
//User
//Impl
//UserImpl