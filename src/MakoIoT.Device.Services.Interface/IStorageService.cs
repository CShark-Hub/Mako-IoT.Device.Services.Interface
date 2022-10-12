
namespace MakoIoT.Device.Services.Interface
{
    public interface IStorageService
    {
        void WriteToFile(string fileName, string text);
        bool FileExists(string fileName);
        string ReadFile(string fileName);
        void DeleteFile(string fileName);
        string[] GetFiles();
        string[] GetFileNames();
    }
}
