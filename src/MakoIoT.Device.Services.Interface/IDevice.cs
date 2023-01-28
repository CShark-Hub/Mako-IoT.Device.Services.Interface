using System;

namespace MakoIoT.Device.Services.Interface
{
    public interface IDevice
    {
        void Start();
        void Stop();

        event EventHandler Starting;
        event EventHandler Stopped;
    }
}
