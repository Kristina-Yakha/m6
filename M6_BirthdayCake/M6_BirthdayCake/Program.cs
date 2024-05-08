using System;

namespace DecoratorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Cake chocolateCake = new Cake("chocolate cake", "dark chocolate");

            //Console.WriteLine(chocolateCake.GetDescription());
            //Console.WriteLine(chocolateCake.EatCake());

            CakeWithFrosting cakeWithFrosting = new CakeWithFrosting(chocolateCake, "strawberry");
           // Console.WriteLine(cakeWithFrosting.GetDescription());
           // Console.WriteLine(cakeWithFrosting.EatCake());

            CakeWithCandles cakeWithFrostingAndCandles = new CakeWithCandles(cakeWithFrosting, 5);
            Console.WriteLine(cakeWithFrostingAndCandles.GetDescription());
            Console.WriteLine(cakeWithFrostingAndCandles.EatCake());
            cakeWithFrostingAndCandles.BlowOutCandles();
            Console.WriteLine(cakeWithFrostingAndCandles.GetDescription());
            Console.WriteLine(cakeWithFrostingAndCandles.EatCake());



        }
    }



}
