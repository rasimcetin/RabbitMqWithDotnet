namespace RabbitMqWithDotnet;

public class Order
{
    public Guid Id { get; set; }

    public string ProductName { get; set; } = string.Empty;

    public int Quantity { get; set; } = 0;

    public string CustomerName { get; set; } = string.Empty;

    public decimal Price { get; set; } = 0;
}
