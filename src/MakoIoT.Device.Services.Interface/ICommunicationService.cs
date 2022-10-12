using System;

namespace MakoIoT.Device.Services.Interface
{
    public interface ICommunicationService
    {
        bool CanSend { get; }
        string ClientAddress { get; }
        string ClientName { get; }
        event EventHandler MessageReceived;
        void Connect(string[] subscriptions);
        void Disconnect();
        void Publish(string messageString, string messageType);
        void Send(string messageString, string recipient);
    }
}
