namespace MakoIoT.Device.Services.Interface
{
    public interface INetworkProvider
    {
        bool IsConnected { get; }
        string ClientAddress { get; }
        void Connect();
        void Disconnect();
    }
}
