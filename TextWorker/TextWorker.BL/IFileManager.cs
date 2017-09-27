namespace TextWorker.BL
{
    public interface IFileManager
    {
        void SaveText(string content, string filepath);
        bool IsExist(string filepath);
        string GetText(string filepath);
    }
}
        