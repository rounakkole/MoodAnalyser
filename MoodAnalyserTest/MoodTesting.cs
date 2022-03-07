using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace MoodAnalyserTest
{
    [TestClass]
    public class MoodTesting
    {
        [TestMethod]
        public void GivenSad_ReturnSad()
        {
            HappySad happySad = new HappySad("iam in sad mood");
            string Result = happySad.AnalysingMood();
            
            Assert.AreEqual("SAD", Result);
        }

        [TestMethod]
        public void GivenHappy_ReturnHappy()
        {
            HappySad happySad = new HappySad("iam in happy mood");
            string Result = happySad.AnalysingMood();

            Assert.AreEqual("HAPPY", Result);
        }


        [TestMethod]
        public void GivenNull_RetunHappy()
        {
            HappySad happySad = new HappySad(null);
            string result = happySad.AnalysingMood();

            Assert.AreEqual("HAPPY", result);
        }
    }
}