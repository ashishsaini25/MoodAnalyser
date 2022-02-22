using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace MsTestingMoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {
        

        [TestMethod]

        public void Moodanalyser_testTC3a()
        {
            string s =null;
            Mood_Analyser mood = new Mood_Analyser(s);
            string moodname = mood.AnalyseMood();
            Assert.AreEqual("The mood is Null", moodname);

        }
        [TestMethod]

        public void Moodanalyser_testTC3b()
        {
            string s ="";
            Mood_Analyser mood = new Mood_Analyser(s);
            string moodname = mood.AnalyseMood();
            Assert.AreEqual("The mood is empty", moodname);

        }
    }
}