using System;

namespace M6_AdapterExercise
{

    public interface IMailServer
    {
        void ConnectAndSendMail(string emailAddress, string content, string receiverName);

       
    }


}