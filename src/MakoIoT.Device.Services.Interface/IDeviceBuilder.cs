using System;
using Microsoft.Extensions.DependencyInjection;

namespace MakoIoT.Device.Services.Interface
{
    public delegate void ConfigureDIDelegate(IServiceCollection services);
    public delegate void ConfigureDefaultsDelegate(IConfigurationService configurationService);
    public delegate void DeviceStartingDelegate(IDevice device);
    public delegate void DeviceStoppedDelegate(IDevice device);

    public interface IDeviceBuilder
    {
        public IServiceCollection Services { get; }

        ConfigureDefaultsDelegate ConfigureDefaultsAction { get; set; }
        IDeviceBuilder ConfigureDI(ConfigureDIDelegate configureDiAction);
        IDevice Build();
        event DeviceStartingDelegate DeviceStarting;
        event DeviceStoppedDelegate DeviceStopped;
    }
}
