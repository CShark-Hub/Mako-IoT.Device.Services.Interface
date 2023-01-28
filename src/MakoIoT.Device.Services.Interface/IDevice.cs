using System;

namespace MakoIoT.Device.Services.Interface
{
    public interface IDevice
    {
        IServiceProvider ServiceProvider { get; }

        void Start();
        void Stop();

        event DeviceStartingDelegate Starting;
        event DeviceStoppedDelegate Stopped;
    }
}
