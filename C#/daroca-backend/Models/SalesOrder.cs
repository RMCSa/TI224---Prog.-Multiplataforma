public class SalesOrder{
    public int SalesOrderId { get; set; }
    public int CustomerId { get; set; }
    public required DateTime OrderDate { get; set; }
    public required DateOnly EstimatedDeliveryDate { get; set; }
    public required string Status { get; set; }
}