using System;
namespace Mediator
{
    public interface IChatMediator
    {
        void SendMessage(string message, User user);

        void SendPrivateMessage(string message, User user, User recipient);
        void AddUser(User user);
    }
}

