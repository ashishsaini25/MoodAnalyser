using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class Program
    {
        public  string AnalyseMood(string s)
        {
            string []wordbag ={"sad","unhappy","gloomy","sombre","melancholy","homesick" };
            string [] words=s.Split(' ');
            bool sad = false;

            for(int i = 0; i < words.Length; i++)
            {
                for(int j=0; j < wordbag.Length; j++)
                {
                    if (words[i].ToLower().CompareTo(wordbag[j]) == 0) sad = true;
                }
            }
            if (sad)
                return "SAD";
            else
                return "HAPPY";
        }
        static void Main(string[] args)
        {
        }
    }
}
