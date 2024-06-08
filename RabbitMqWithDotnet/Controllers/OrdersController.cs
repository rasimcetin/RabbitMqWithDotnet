using Microsoft.AspNetCore.Mvc;

namespace RabbitMqWithDotnet;

[ApiController]
[Route("[controller]")]
public class OrdersController(IOrderService orderService, IMessageProcucer messageProcucer) : ControllerBase 
{
    [HttpPost]
    public Task<IActionResult> Post(OrderDto order){

        var orderId = orderService.CreateOrder(order);

        messageProcucer.SendMessage(order);

        return Task.FromResult<IActionResult>(Ok(new {id= orderId}));

    }
}
