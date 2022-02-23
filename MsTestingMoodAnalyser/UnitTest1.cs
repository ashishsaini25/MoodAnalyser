using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace MsTestingMoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {
         
        [TestMethod]
        public void Moodanalyser_testTC4a()
        {
            
            object expected = new Mood_Analyser();
            object obj = ModeAnalyserFactory.CreateMoodAnalyser("MoodAnalyser.Mood_Analyser", "Mood_Analyser");
            var expectedtype = expected.GetType();
            var objtype = obj.GetType();
            var result=expectedtype==objtype;
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Moodanalyser_testTC4b()
        {

            object expected = new Mood_Analyser();
            object obj = ModeAnalyserFactory.CreateMoodAnalyser("MoodAnalysr.Mood_Analyser", "Mood_Analyser");
            string responce=obj.ToString();
            Assert.AreEqual("MoodAnalyser.MoodAnalyserException: No such Class", responce);
        }
        [TestMethod]
        public void Moodanalyser_testTC4c()
        {

            object expected = new Mood_Analyser();
            object obj = ModeAnalyserFactory.CreateMoodAnalyser("MoodAnalyser.Mood_Analyser", "Mood_Analyse");
            string responce = obj.ToString();
            Assert.AreEqual("MoodAnalyser.MoodAnalyserException: No Such Method", responce);
        }
    }
}