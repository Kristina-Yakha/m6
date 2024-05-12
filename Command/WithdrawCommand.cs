using System;
namespace Command
{
    public class WithdrawCommand : IBankTransactionCommand
    {
        private BankAccount bankAccount;
        private double amount;
        public bool Success { get; set; }

        public WithdrawCommand(BankAccount bankAccount, double amount)
        {
            this.bankAccount = bankAccount;
            this.amount = amount;
            this.Success = false;
        }

        public void Execute()
        {
            
            try
            {
                
                bankAccount.Withdraw(amount);
                Success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                
            }
            
        }

        public void Undo()
        {
            
            if (Success)
            {
                Console.WriteLine("The withdraw command has been undone: ");
                bankAccount.Deposit(amount);
            } 
            else
            {
                Console.WriteLine("Undo was not successfull");
            }
            
        }
    }
}

