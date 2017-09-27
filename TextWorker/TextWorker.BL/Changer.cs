using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace TextWorker.BL
{
    public class Changer : IChanger
    {

        string content { get; set; }
        string currentText { get; set; }
        string newText { get; set; }
        public string[] lines;
        private static int l;
        private static string[][] words = new string[l][];
        private static int lic;

        

        public Changer(string content, string[] lines)
        {
            this.content = content;
            this.lines = lines;
        }

        public string[] MakeLines(string sym, string[] lines)
        {
            List<string> lin = new List<string>();

            string add = "";
            string[] line;
        
            for (int i = 0; i < lines.Length; i++)
            {
                if (!(lines[i].Contains(sym))) add += lines[i];

                else
                {
                    line = lines[i].Split(sym.ToCharArray());
                    for(int j=0;j<line.Length;j++)
                    {
                        add += line[j];
                        lin.Add(add);
                        add = "";
                    }
                    add = line[line.Length - 1];
                }  
            }
            return lin.ToArray();
        }

        public string[] DelLines(int a, string[] lines)
        {
            List<string> line = new List<string>();

            for (int i = 0; i < lines.Length; i++)
            {
                if(lines[i] == "")
                {
                    line.Add(lines[i]);
                }

                switch (a)
                {
                    case 0:
                        if (lines[i].Length > 21) line.Add(lines[i]);
                        break;

                    case 1:
                        if (lines[i].Length < 21) line.Add(lines[i]);
                        break;
                }
            }
            return line.ToArray();
        }

        public string[] ClearText(string line, string content, string[] lines)
        {
            First(content, lines);
            List<string> lin = new List<string>();

            for(int i = 0; i<lines.Length; i++)
            {
                if (!(lines[i].Contains(line))) lin.Add(lines[i]);
            }

            return lin.ToArray();
        }

        public string[] DestEng(string[] lines)
        {
            List<string> line = new List<string>();
            string current;

            for (int i = 0; i < lines.Length; i++)
            {
               current = string.Join("", Regex.Matches(lines[i], "[а-я]", RegexOptions.IgnoreCase).Cast<object>());
                line.Add(current);
            }
            return line.ToArray();
        }

       /* private void GetLinesCount(string[] content)
        {
            for (int i = 0; i < content.Length; i++)
            {
                if (content[i] == '.') l++;
                if (content[content.Length - 1] != '.') l++;
            }
        }  */

        private void MakeSentence(string content, int l)
        {
            for (int i = 0; i < content.Length; i++)
            {
                if (content[i] == '.')
                {
                    var j = i;
                    while (content[j] != '.' && j > -1)
                    {
                        lines[lic] += content[j];
                        j--;
                    }
                    lic++;
                }
            }
        }

        private void MakeWords(string[] lines)
        {
            int lich = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < lines[i].Length; j++)
                {
                    if (lines[i][j] == ' ')
                    {
                        lich++;
                        while (lines[i][j] != ' ' || j > 0) words[i][lich] += lines[i][j];
                    }
                }
                lich = 0;
            }
        }

        private void First(string content, string[] lines)
        {
            this.lines = lines;
            this.content = content;
        } 

    }
}
