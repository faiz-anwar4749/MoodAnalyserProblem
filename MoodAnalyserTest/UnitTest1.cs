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
            var result = mood.AnalyseMood();
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string expected = "HAPPY";
            MoodAnalyse moodAnalyse = new MoodAnalyse(null);

            string mood = moodAnalyse.AnalyseMood();

            Assert.AreEqual(expected, mood);
        }
    }
}
