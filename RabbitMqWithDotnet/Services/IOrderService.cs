namespace RabbitMqWithDotnet;

public interface IOrderService
{
    Guid CreateOrder(OrderDto order);
}
