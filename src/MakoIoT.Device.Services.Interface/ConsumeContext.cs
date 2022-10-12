using System;
using MakoIoT.Messages;

namespace MakoIoT.Device.Services.Interface
{
    public class ConsumeContext
    {
        public ConsumeContext(Envelope envelope)
        {

            Message = envelope.Message;
            MessageId = envelope.MessageId;
            OriginTime = envelope.OriginTime;
            Sender = envelope.Sender;
            SenderAddress = envelope.SenderAddress;
            ReceivedTime = DateTime.UtcNow;
        }

        public string SenderAddress { get; }

        public string Sender { get; }

        public DateTime OriginTime { get; }

        public string MessageId { get; }

        public IMessage Message { get; }

        public DateTime ReceivedTime { get; }
    }
}
