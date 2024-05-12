using System;
using System.Collections;

namespace Command
{
    public class BankAccount
    {
        public double Balance { get; set; } = 0;
        public double OverdraftLimit { get; set; } = 1000;
      

        public BankAccount()
        {
            
        }
        
        

        public void Deposit(double amount)
        {
            Balance += amount; //Balance = Balance + amount;
            Console.WriteLine($"{amount} Euros have been deposited into the account.");
           
        }

        public void Withdraw(double amount)
        {
            
            if((Balance - amount) <= (-OverdraftLimit))
            {
                //Console.WriteLine("Overdraft limit has been reached. The withdraw order has been terminated");
                throw new Exception("Overdraft limit has been reached. The withdraw order has been terminated");

            } else
            {
                Balance -= amount;
                Console.WriteLine($"{amount} Euros have been withdrawn from the account. The new balance is {Balance} Euros.");
                
            }
            
           
        
        }

    

        public override string ToString()
        {
            return $"Account balance: {Balance} Euros, Overdraft limit: {OverdraftLimit} Euros";
        }
    }
}

