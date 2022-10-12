using System;

namespace MakoIoT.Device.Services.Interface
{
    public interface IScheduler
    {
        void Start(Action action, int interval, string id);
        void Stop(string id);
        void StopAll();
    }
}
