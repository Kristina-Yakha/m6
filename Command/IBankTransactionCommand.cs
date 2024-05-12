using System;
namespace Command
{
	public interface IBankTransactionCommand
	{

        public bool Success { get; set; }
        void Execute();

        void Undo();
     }
}

