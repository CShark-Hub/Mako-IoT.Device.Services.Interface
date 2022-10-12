using System;
using MakoIoT.Messages;

namespace MakoIoT.Device.Services.Interface
{
    public delegate void MessageEventHandler(object sender, MessageEventArgs args);

    public interface IDataProvider
    {
        string Id { get; }
        void GetData();
        event MessageEventHandler DataReceived;
    }

    public class MessageEventArgs : EventArgs
    {
        public MessageEventArgs(IMessage message)
        {
            Message = message;
        }

        public IMessage Message { get; }
    }
}
