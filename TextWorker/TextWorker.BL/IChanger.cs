namespace TextWorker.BL
{
    public interface IChanger  
    {
        string[] MakeLines(string symbol, string[] lines);
        string[] DelLines(int a, string[] lines);
        string[] ClearText(string line, string content, string[] lines);
        string[] DestEng(string[] lines);
    }
}
