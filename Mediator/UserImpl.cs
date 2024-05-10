using System;
namespace Mediator
{
    public class UserImpl : User
    {
        public UserImpl(string name, IChatMediator mediator) : base(name, mediator) { }

        public override void ReceiveMessage(string message, User user)
        {
            Console.WriteLine(Name + " has received a message from " + user.Name); 
            Console.WriteLine(user.Name + ": " + message);
        }

        public override void SendMessage(string message)
        {
            //Console.WriteLine(Name + ": " + message);
            Mediator.SendMessage(message, this);
        }

        public override void SendPrivateMessage(string message, User recipient)
        {
            //Console.WriteLine($"{Name}(whispers): {message}");
            Mediator.SendPrivateMessage(message, this, recipient);
        }
    }
}

