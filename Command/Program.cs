namespace Command;

class Program
{
    static void Main(string[] args)
    {
        BankAccount timoBA = new BankAccount();
        Console.WriteLine("Account was opened: " + timoBA.ToString());

        CashMachine cashMachineSC = new CashMachine();

        IBankTransactionCommand command1 = new DepositCommand(timoBA, 500);
        IBankTransactionCommand command2 = new WithdrawCommand(timoBA, 5000);
        //IBankTransactionCommand command3 = new DepositCommand(timoBA, 1000);

        cashMachineSC.ExecuteBankTransaction(command1);
        cashMachineSC.ExecuteBankTransaction(command2);
        //cashMachineSC.ExecuteBankTransaction(command3);
        cashMachineSC.UndoLastBankTransaction();
        cashMachineSC.UndoLastBankTransaction();

        Console.ReadKey();
    }
}
//Bankaccount->IbankTrans->Depo->With->Cash

/* An welcher Stelle ist das error-handling am besten aufgehoben? Soll ich verhindern, dass ein fehlerhaftes Command in einen Stack kommt, oder soll ich es zulassen und beim Undo noch einen Fehler werfen?
