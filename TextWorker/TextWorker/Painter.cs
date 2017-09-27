using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextWorker
{
    class Painter
    {
        string Contetn { get; set; }
        string[] Lines { get; set; }
        string[] Words { get; set; }
        int CurrentIndex { get; set; }
        int[] Lenghts { get; set; }
        public int [][] Indexes { get; set; }

        public Painter()
        {
            CurrentIndex = 0;
        }

        public Painter(string content, string[] words)
        {
            this.Contetn = content;
            Words = Contetn.Split(' ');
            CurrentIndex = 0;
            GetIndex(words);
        }

        public Painter(string[] lines)
        {
            this.Lines = lines;
            CurrentIndex = 0;
        }

        public void GetIndex(string[] words)
        {
            int index = 0;
            var ind = new List<int>();
            
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < Contetn.Length; j++)
                {
                    if (Contetn.Contains(words[i]))
                    {
                        index = Contetn.IndexOf(words[i], CurrentIndex + words[i].Length);
                        CurrentIndex = index;
                        ind.Add(index);
                    }
                }
                CurrentIndex = 0;
                Indexes[i] = ind.ToArray();
            }
        }

        public void GetProperties(string content)
        {
            this.Contetn = content;
            this.Words = Contetn.Split(' ');
        }

    }
}
