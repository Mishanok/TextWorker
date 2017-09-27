using System;
using System.IO;

namespace TextWorker.BL
{
    public class FileManager : IFileManager
    {
        public string GetText(string filepath)
        {
            string content = null;
            if (IsExist(filepath))
            {
                content = File.ReadAllText(filepath);
            }
            return content;
        }          

        public bool IsExist(string filepath)
        {
            bool res = File.Exists(filepath) ;
            return res;
        }      
 

        public void SaveText(string content, string filepath)
        {
            File.WriteAllText(filepath, content);
        }
    }
}
