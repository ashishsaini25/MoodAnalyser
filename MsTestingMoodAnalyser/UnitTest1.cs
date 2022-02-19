using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace MsTestingMoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
       
        public void Moodanalyser_testTC1a()
        {
          Program mood=new Program();
            string moodname = mood.AnalyseMood(" I am in Sad Mood");
            Assert.AreEqual("SAD", moodname);
           
        }

        [TestMethod]

        public void Moodanalyser_testTC1b()
        {
            Program mood = new Program();
            string moodname = mood.AnalyseMood(" I am in Any Mood");
            Assert.AreEqual("HAPPY", moodname);

        }
    }
}