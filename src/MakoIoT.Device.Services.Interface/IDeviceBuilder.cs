using System;
using nanoFramework.DependencyInjection;

namespace MakoIoT.Device.Services.Interface
{
    public delegate void ConfigureDefaultsDelegate(IConfigurationService configurationService);
    public delegate void DeviceStartingDelegate(IDevice device);
    public delegate void DeviceStoppedDelegate(IDevice device);

    public interface IDeviceBuilder
    {
        public IServiceCollection Services { get; }

        ConfigureDefaultsDelegate ConfigureDefaultsAction { get; set; }
        IDeviceBuilder ConfigureDI(Action configureDiAction);
        IDevice Build();
        event DeviceStartingDelegate DeviceStarting;
        event DeviceStoppedDelegate DeviceStopped;
    }
}
