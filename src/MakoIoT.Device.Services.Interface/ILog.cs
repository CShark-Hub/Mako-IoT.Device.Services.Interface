using System;
using System.Reflection;

namespace MakoIoT.Device.Services.Interface
{
    public interface ILog
    {
        void Trace(Exception exception, string message, MethodInfo format);
        void Trace(Exception exception, string message);
        void Trace(string message);
        void Trace(Exception exception);

        void Information(Exception exception, string message, MethodInfo format);
        void Information(Exception exception, string message);
        void Information(string message);
        void Information(Exception exception);

        void Warning(Exception exception, string message, MethodInfo format);
        void Warning(Exception exception, string message);
        void Warning(string message);
        void Warning(Exception exception);

        void Error(Exception exception, string message, MethodInfo format);
        void Error(string message, Exception exception);
        void Error(string message);
        void Error(Exception exception);

        void Critical(Exception exception, string message, MethodInfo format);
        void Critical(Exception exception, string message);
        void Critical(string message);
        void Critical(Exception exception);
    }
}