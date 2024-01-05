namespace MakoIoT.Device.Services.Interface
{
    /// <summary>
    /// Behavior executed when device is initializing.
    /// Should be used for hardware initialization.
    /// </summary>
    public interface IDeviceInitializationBehavior
    {
        /// <summary>
        /// Executed when device is starting.
        /// </summary>
        /// <returns>True, if following logic should be executed; False if execution chain should stop.</returns>
        bool DeviceInitialization();
    }
}