using System;

namespace M6_SingletonPatternAssignment
{

    public class StandardInterestRate       
    {
        private static readonly StandardInterestRate instance = new StandardInterestRate();
        private decimal currentInterestRate = 0.03m;

        public decimal CurrentInterestRate 
        {
            get
            {
                return currentInterestRate;
            } 
            set
            {
               currentInterestRate = value;
            } 
        }

        private StandardInterestRate() 
        {
            Console.WriteLine("StandardInterestRate has been created");
                      
        
        }

      
        public static StandardInterestRate GetInstance()
        {
            return instance;
        }





      
    }





}

