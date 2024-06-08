namespace RabbitMqWithDotnet;

public interface IMessageProcucer
{
    void SendMessage<T>(T message);
}
