
namespace RabbitMqWithDotnet;

public class OrderService : IOrderService
{
    private static List<Order> _orders = new List<Order>();

    public Guid CreateOrder(OrderDto order)
    {
        var newOrder = new Order
        {
            Id = Guid.NewGuid(),
            ProductName = order.ProductName,
            Quantity = order.Quantity,
            CustomerName = order.CustomerName,
            Price = order.Price
        };
        _orders.Add(newOrder);
        return newOrder.Id;
    }
}
