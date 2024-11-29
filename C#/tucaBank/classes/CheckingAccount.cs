namespace Classes;

public class CheckingAccount : Account
{
    private double overdraft = -500.00;

    public CheckingAccount(string owner) : base(owner)
    {

    }

    public CheckingAccount(string owner, double balance) : base(owner, balance)
    {

    }

    public override void MakeWithdrawal(double amount, DateTime date, string notes)
    {
        if (balance - amount > overdraft)
        {
            transactions.Add(new Transaction(-amount, DateTime.Now, notes));
        }

        this.balance -= amount;
    }

    public override void PerformMonthEndTransactions()
    {
        if (balance < 0)
        {
            double interestEarned = -balance * 0.03;
            MakeWithdrawal(interestEarned, DateTime.Now, "Charge monthly interest");
        }
    }
}