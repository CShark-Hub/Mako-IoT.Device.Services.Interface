namespace MakoIoT.Device.Services.Interface
{
    public interface ITask
    {
        string Id { get; }
        void Execute();
    }
}
