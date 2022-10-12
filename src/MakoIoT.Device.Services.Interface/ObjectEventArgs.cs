using System;

namespace MakoIoT.Device.Services.Interface
{
    public class ObjectEventArgs : EventArgs
    {
        public ObjectEventArgs(object data)
        {
            Data = data;
        }

        public object Data { get; }
    }
}
