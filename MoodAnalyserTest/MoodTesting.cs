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


        /*[TestMethod]
        public void GivenNull_RetunHappy()
        {
            HappySad happySad = new HappySad(null);
            string result = happySad.AnalysingMood();

            Assert.AreEqual("HAPPY", result);
        }*/


        [TestMethod]
        public void GivenNull_RetunCustomException()
        {
            try
            {
                HappySad happySad = new HappySad();
                string result = happySad.AnalysingMood();
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("message should not be null", ex.Message);
            }
        }

        [TestMethod]
        public void GivenEmpty_RetunCustomException()
        {
            try
            {
                HappySad happySad = new HappySad("");
                string result = happySad.AnalysingMood();
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("message should not be empty", ex.Message);
            }
        }





        [TestMethod]
        public void GivingClassNameRight_ReturnsObject()
        {
            //HappySad happySad = new HappySad();
            object Expected = new HappySad();
            MoodAnalyserFactory factory = new MoodAnalyserFactory("MoodAnalyser.HappySad", "HappySad");
            object MyObj = MoodAnalyserFactory.FactoryMethod(factory);
            Expected.Equals(MyObj);
        }


        [TestMethod]
        public void GivingClassNameWrong_RetunCustomException()
        {
            try
            {
                MoodAnalyserFactory factory = new MoodAnalyserFactory("MoodAnalyser.HappySad", "HappySad");
                var MyObj = MoodAnalyserFactory.FactoryMethod(factory);
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("class name is wrong", ex.Message);
            }
        }


        [TestMethod]
        public void GivingConstructorWrong_RetunCustomException()
        {
            try
            {
                MoodAnalyserFactory factory = new MoodAnalyserFactory("MoodAnalyser.HappySad", "HappySa");
                var MyObj = MoodAnalyserFactory.FactoryMethod(factory);
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("constructor name is wrong", ex.Message);
            }
        }


    }
}