public class Person
{
   private string name;
   private string address;

    public Person(string name, string address)
    {
        this.name = name;
        this.address = address;
    }

    public string GetName() => name;
    public string GetAddress() => address;

    public bool Equals (Person another){
        return this.name == another.name && this.address == another.address;
    }

    public override string ToString()
    {
        return $"Name: {name}, Address: {address}";
    }
}