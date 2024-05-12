using System;
namespace Command
{
    public class DepositCommand : IBankTransactionCommand
    {
        private BankAccount bankAccount; //reference the owner
        private double amount; //the deposit amount 
        public bool Success { get; set; }


        public DepositCommand(BankAccount bankAccount, double amount) //constr
        {
            this.bankAccount = bankAccount;
            this.amount = amount;
            this.Success = false;
        }

        public void Execute()
        {

            try
            {

                bankAccount.Deposit(amount);
                Success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }


        }

        public void Undo() 
        {
            Console.WriteLine("The desposit command has been undone: ");
            bankAccount.Withdraw(amount);
        }



    }
}

