using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace MsTestingMoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {
        

        [TestMethod]

        public void Moodanalyser_testTC2a()
        {
            Program mood = new Program();
            string s=null;
            string moodname = mood.AnalyseMood(s);
            Assert.AreEqual("HAPPY", moodname);

        }
    }
}