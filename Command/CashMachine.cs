using System;
using System.Collections;

namespace Command
{

   
	public class CashMachine
	{
        public Stack<IBankTransactionCommand> commandHistory;

        public CashMachine() { 
        
            commandHistory = new Stack<IBankTransactionCommand>();
        
        
        }


        public void ExecuteBankTransaction(IBankTransactionCommand command)
        {
            
            
          command.Execute();
          
          commandHistory.Push(command);
            
           
            
            
            
        }

        public void UndoLastBankTransaction()
        {

            IBankTransactionCommand command = commandHistory.Pop();
            command.Undo();
          



        }
       
        

    }
}

