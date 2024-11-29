namespace Classes;

public class Account
{
    private static int accountNumberSeed = 1234567890;
    protected string number;
    protected string owner;
    protected double balance;
    protected List<Transaction> transactions;

    public Account(string owner, double initialBalance)
    {
        this.number = accountNumberSeed.ToString();
        this.owner = owner;
        this.transactions = new List<Transaction>();
        this.MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
        accountNumberSeed++;
    }

    public Account(string owner) : this(owner, 0)
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
        this.balance += amount;
    }

    public virtual void MakeWithdrawal(double amount, DateTime date, string notes)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
        }
        
        if (balance - amount < 0)
        {
            throw new InvalidOperationException("Not sufficient funds for this withdrawal");
        }
        
        this.transactions.Add(new Transaction(-amount, date, notes));
        this.balance -= amount;
    }

    public virtual void PerformMonthEndTransactions()
    {

    }

    public string GetAccountHistory()
    {
        var report = new System.Text.StringBuilder();
        report.AppendLine("Date\t\tAmount\tBalance\tNote");
        double balance = 0.0;

        foreach (var transaction in this.transactions)
        {
            balance += transaction.GetAmount();
            report.AppendLine($"{transaction.GetDate().ToShortDateString()}\t{transaction.GetAmount()}\t{balance}\t{transaction.GetNotes()}");
        }

        return report.ToString();
    }

    public override string ToString()
    {
        return "${this.owner}, balance = R${this.balance()}";
    }
}