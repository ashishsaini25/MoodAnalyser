using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class ModeAnalyserFactory
    {
        public static object CreateMoodAnalyser(string classname,string constructorName)
        {
            string pattern = @"."+constructorName+"$";
            Match result = Regex.Match(classname, pattern);
            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodanalysis = executing.GetType(classname);
                    return Activator.CreateInstance(moodanalysis);
                }
                catch(ArgumentNullException)
                {
                    return  new MoodAnalyserException(MoodAnalyserException.ExceptionType.IMPROPER_CLASS_NAME, "No such Class");
                }
            }
            else
            {
                return new MoodAnalyserException(MoodAnalyserException.ExceptionType.IMPROPER_CONSTRUCTOR_NAME, "No Such Method");
            }
        }
    }
}
