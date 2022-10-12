using System;

namespace MakoIoT.Device.Services.Interface
{
    public delegate void ConfigureDefaultsDelegate(IConfigurationService configurationService);
    public interface IDeviceBuilder
    {
        ConfigureDefaultsDelegate ConfigureDefaultsAction { get; set; }
        IDeviceBuilder ConfigureDI(Action configureDiAction);
        IDevice Build();
        event EventHandler DeviceStarting;
        event EventHandler DeviceStopped;
    }
}
