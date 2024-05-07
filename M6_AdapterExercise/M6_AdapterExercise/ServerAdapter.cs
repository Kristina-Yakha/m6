using System;

namespace M6_AdapterExercise
{
    public class ServerAdapter : IMailServer
    {

        private GoogleMailServer googleMailServer;

        public ServerAdapter(GoogleMailServer googleMailServer)
        {
            this.googleMailServer = googleMailServer;
        }

        public void ConnectAndSendMail(string emailAddress, string content, string receiverName)
        {

            ConnectToServer(emailAddress);
            EncryptEmail();
                       
            googleMailServer.SendEmail(receiverName, content);
            

        }

     
        private void EncryptEmail()
        {
            Console.WriteLine("Email successfully encrypted..");
        }

        private void ConnectToServer (string emailAddress)
        {
            Console.WriteLine("Email Address: " + emailAddress);
            googleMailServer.BuildConnection();
        }



    }

}


