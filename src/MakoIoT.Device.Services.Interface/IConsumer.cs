namespace MakoIoT.Device.Services.Interface
{
    public interface IConsumer
    {
        void Consume(ConsumeContext context);
    }
}