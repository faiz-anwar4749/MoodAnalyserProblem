using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mood_Analyser;
namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("I am in happy mood.")]
        [DataRow("I am in any mood.")]
        public void TestMethod1(string message)
        {
            string expected = "HAPPY";
            MoodAnalyse mood = new MoodAnalyse(message);
            var result = mood.AnalyseMood1();
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Throw_MoodAnalysisException_Indicating_EmptyMood()
        {
            try
            {
                string message = string.Empty;
                MoodAnalyse mood = new MoodAnalyse(message);
                string moodStr = mood.AnalyseMood1();
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be empty", e.Message);
            }
        }
        [TestMethod]
        public void Throw_MoodAnalysisException_Indicating_Null()
        {
            try
            {
                string message = null;
                MoodAnalyse moodAnalyse = new MoodAnalyse(message);
                string mood = moodAnalyse.AnalyseMood1();
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be null.", e.Message);
            }
        }
    }
}
