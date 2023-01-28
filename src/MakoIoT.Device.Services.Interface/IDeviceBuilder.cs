using System;
using nanoFramework.DependencyInjection;

namespace MakoIoT.Device.Services.Interface
{
    public delegate void ConfigureDefaultsDelegate(IConfigurationService configurationService);
    public interface IDeviceBuilder
    {
        public IServiceCollection Services { get; }

        ConfigureDefaultsDelegate ConfigureDefaultsAction { get; set; }
        IDeviceBuilder ConfigureDI(Action configureDiAction);
        IDevice Build();
        event EventHandler DeviceStarting;
        event EventHandler DeviceStopped;
    }
}
