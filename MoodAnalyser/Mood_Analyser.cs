using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class Mood_Analyser
    {
        public string message;

        public  Mood_Analyser()
        {
        }
        //public Mood_Analyser(string message)
        //{
        //    this.message=message;
        //}
        public string AnalyseMood()
        {
            try
            {
              
                bool sad = false;
                if (message == string.Empty)
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.EMPTY_MOOD, "The mood is empty");
                }
                if (this.message==null)
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.EMPTY_MOOD, "The mood is Null");
                }
                string[] wordbag = { "sad", "unhappy", "gloomy", "sombre", "melancholy", "homesick" };
                string[] words = message.Split(' ');
                for (int i = 0; i < words.Length; i++)
                {
                    for (int j = 0; j < wordbag.Length; j++)
                    {
                        if (words[i].ToLower().CompareTo(wordbag[j]) == 0) sad = true;
                    }
                }
                if (sad)
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch(MoodAnalyserException e)
            {
                return e.Message;
            }
           
        }
    }
}
