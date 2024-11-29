public interface IAccount
{
    string GetNumber();
    string GetOwner();
    double GetBalance();
    void MakeDeposit(double amount, DateTime date, string notes);
    void MakeWithdrawal(double amount, DateTime date, string notes);
    void PerformMonthEndTransactions();
}