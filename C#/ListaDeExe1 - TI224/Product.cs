using System.Net.Http.Headers;

public class Product
{
    private int id;
    private string name;
    private decimal price;

    public Product(int id, string name, decimal price)
    {
        this.id = id;
        this.name = name;
        this.price = price;
    }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public decimal Price
    {
        get { return price; }
        set { price = value; }
    }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
}
    public bool Equals(Product another)
    {
        if (this.id == another.id && this.name == another.name && this.price == another.price)
        {
            return true;
        }
        return false;
    }
}
