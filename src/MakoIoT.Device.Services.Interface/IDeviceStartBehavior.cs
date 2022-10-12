namespace MakoIoT.Device.Services.Interface
{
    /// <summary>
    /// Behavior executed when device is starting.
    /// </summary>
    public interface IDeviceStartBehavior
    {
        /// <summary>
        /// Executed when device is starting.
        /// </summary>
        /// <returns>True, if following logic should be executed; False if execution chain should stop.</returns>
        bool DeviceStarting();
    }
}
