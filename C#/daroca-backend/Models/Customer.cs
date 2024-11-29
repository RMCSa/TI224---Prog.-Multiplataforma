
public class Customer{
    public required int CustomerId { get; set; }
    public required string Name { get; set; }
    public required string City { get; set; }
    public required string State { get; set; }

    public required decimal Latitude { get; set; }
    public required decimal Longitude { get; set; }


    public Customer(int customerId, string name, string city, string state, decimal latitude, decimal longitude){
        CustomerId = customerId;
        Name = name;
        City = city;
        State = state;
        Latitude = latitude;
        Longitude = longitude;

    }
}