using System;
using System.Reflection;

namespace MakoIoT.Device.Services.Interface
{
    public interface ILog
    {
        void Trace(string message, Exception exception, MethodInfo format);
        void Trace(string message);
        void Trace(Exception exception);

        void Information(string message, Exception exception, MethodInfo format);
        void Information(string message);
        void Information(Exception exception);

        void Warning(string message, Exception exception, MethodInfo format);
        void Warning(string message);
        void Warning(Exception exception);

        void Error(string message, Exception exception, MethodInfo format);
        void Error(string message);
        void Error(Exception exception);

        void Critical(string message, Exception exception, MethodInfo format);
        void Critical(string message);
        void Critical(Exception exception);
    }
}