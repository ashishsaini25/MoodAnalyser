using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyserException:Exception
    {
        public enum ExceptionType
        {
            NULL_MOOD,
            EMPTY_MOOD,
            IMPROPER_CLASS_NAME,
            IMPROPER_CONSTRUCTOR_NAME
        }
        public ExceptionType exceptionType;
        public MoodAnalyserException(ExceptionType type, string message) : base(message)
        {
            this.exceptionType = type;
        }
    }
}
