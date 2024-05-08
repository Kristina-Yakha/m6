using System;

namespace M6_SingletonPatternAssignment
{

    class Program
    {
        static void Main(string[] args)
        {
            StandardInterestRate sir = StandardInterestRate.GetInstance();
            Console.WriteLine("Current Interest Rate default: " + sir.CurrentInterestRate);
            sir.CurrentInterestRate = 0.05m;
            Console.WriteLine("Current Interest Rate changed to: " +sir.CurrentInterestRate);
        }
    }
}


SOne