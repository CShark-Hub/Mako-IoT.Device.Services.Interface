using System;
using nanoFramework.DependencyInjection;

namespace MakoIoT.Device.Services.Interface
{
    public interface IDevice
    {
        public IServiceCollection Services { get; }

        void Start();
        void Stop();

        event EventHandler Starting;
        event EventHandler Stopped;
    }
}
