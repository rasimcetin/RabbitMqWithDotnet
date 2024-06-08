using RabbitMqWithDotnet;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddSingleton<IOrderService, OrderService>();
    builder.Services.AddSingleton<IMessageProcucer, RabbitMqProducer>();
    builder.Services.AddControllers();
}

var app = builder.Build();
{
    app.MapControllers();
}

app.Run();
