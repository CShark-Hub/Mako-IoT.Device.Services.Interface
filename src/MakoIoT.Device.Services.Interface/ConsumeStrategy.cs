namespace MakoIoT.Device.Services.Interface
{
    public enum ConsumeStrategy : byte
    {
        FIFO,
        LastMessageWins,
        Synchronous
    }
}
