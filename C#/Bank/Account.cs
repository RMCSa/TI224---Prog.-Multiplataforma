public class Account{
    //atributos:
    private string owner;
    private double balance = 0;

    //propriedades: -> Não estão no Construtor
    public string Number { get; set;}
    public string Owner{
        get{
            return this.owner;
        }
    }
    public double Balance{
        get{
            return this.balance;
        }
        set{
            this.balance = value;
        }
    }
/*
    public Account(string owner, string number, double balance){
        this.owner = owner;
        Number = number;
        this.balance = balance;
    }
*/
    public Account(string owner, double balance)
    {
        this.owner = owner;
        this.balance = balance;
    }

    public void MakeDeposit(double amount){
        this.balance += amount;
    }

    public void MakeWithDrawal(double amount){
        if ( amount < this.balance)
            this.balance -= amount;
        
    }

    public override string ToString()
    {
        return "Owner: " + owner + "\n" + 
                "Number: " + Number + "\n" +
                "Balance: " +  balance;
    }

    public override bool Equals(object? obj)
    {


        return false;
    }

}
