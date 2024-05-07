using System;

namespace M6_AdapterExercise
{

    public class GoogleMailServer
    {

        //Preparing GoogleMailServer object

        public GoogleMailServer() 
        { 
        
        }

        //Building a connection to an account

        public void BuildConnection()
        {
            Console.WriteLine("Connection to the mail account established!");
                
        }

        //Sending an email

        public void SendEmail(string receiverEmail, string content)
        {
            Console.WriteLine("The email was sent to " + receiverEmail + ".");
            Console.WriteLine("Content: " + content);
        }

    }


}
