using System;
using MakoIoT.Messages;

namespace MakoIoT.Device.Services.Interface
{
    public interface IMessageBus
    {
        void Start();
        void Stop();
        void RegisterDirectMessageConsumer(Type messageType, Type consumerType, ConsumeStrategy consumeStrategy);
        void RegisterSubscriptionConsumer(Type messageType, Type consumerType, ConsumeStrategy consumeStrategy);
        void Publish(IMessage message, bool delay = false);
        void Send(IMessage message, string recipient);
    }
}