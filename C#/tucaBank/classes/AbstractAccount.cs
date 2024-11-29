namespace Classes;

public abstract class AbstractAccount : IAccount
{
    private static int accountNumberSeed = 1234567890;
    protected string number;
    protected string owner;
    protected double balance;
    protected List<Transaction> transactions;

    public AbstractAccount(string owner, double initialBalance)
    {
        this.number = accountNumberSeed.ToString();
        this.owner = owner;
        this.transactions = new List<Transaction>();
        this.MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
        accountNumberSeed++;
    }

    public AbstractAccount(string owner) : this(owner, 0)
    {
        
    }

    public string GetNumber()
    {
        return this.number;
    }

    public string GetOwner()
    {
        return this.owner;
    }

    public double GetBalance()
    {
        return this.balance;
    }

    public void MakeDeposit(double amount, DateTime date, string notes)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
        }
        
        this.transactions.Add(new Transaction(amount, date, notes));
    }

    public abstract void MakeWithdrawal(double amount, DateTime date, string notes);

    public virtual void PerformMonthEndTransactions()
    {
        
    }
}