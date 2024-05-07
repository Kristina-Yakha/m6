using System;

namespace M6_AdapterExercise
{

    class Program
    {

        public static void Main(string[] args)
        {
            GoogleMailServer googleMailServer = new GoogleMailServer();
            IMailServer serverAdapter = new ServerAdapter(googleMailServer);


            Console.WriteLine("Your Email Address: ");
            string emailAddress =  Console.ReadLine();
            Console.WriteLine("Your Message: ");
            string content = Console.ReadLine();
            Console.WriteLine("Receiver: ");
            string receiver = Console.ReadLine();


            serverAdapter.ConnectAndSendMail(emailAddress, content, receiver);

            Console.ReadKey();

        }

        
    }
}