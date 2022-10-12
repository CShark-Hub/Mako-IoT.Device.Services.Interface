using System;

namespace MakoIoT.Messages
{
    public class Envelope
    {
        public DateTime OriginTime { get; set; }
        public string Sender { get; set; }
        public string SenderAddress { get; set; }
        public string MessageId { get; set; }
        public IMessage Message { get; set; }
    }
}
