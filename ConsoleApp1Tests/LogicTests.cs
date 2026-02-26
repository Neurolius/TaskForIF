using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void GetWordRubleTest1()
        {
            Assert.AreEqual("рубль", Logic.GetWord(1, "рубль", "рубля", "рублей"));
        }
        [TestMethod()]
        public void GetWordRubleTest2()
        {
           Assert.AreEqual("рубля", Logic.GetWord(2, "рубль", "рубля", "рублей"));
        }
        [TestMethod()]
        public void GetWordRubleTest3()
        {
            Assert.AreEqual("рублей", Logic.GetWord(5, "рубль", "рубля", "рублей"));
        }
        [TestMethod()]
        public void GetWordRubleTest4()
        {         
            Assert.AreEqual("рублей", Logic.GetWord(11, "рубль", "рубля", "рублей"));
        }
        [TestMethod()]
        public void GetWordRubleTest5()
        {
            Assert.AreEqual("рубль", Logic.GetWord(21, "рубль", "рубля", "рублей"));
        }


        [TestMethod()]
        public void GetWordPennyTest1()
        {
            Assert.AreEqual("копейка", Logic.GetWord(1, "копейка", "копейки", "копеек"));
        }
        public void GetWordPennyTest2()
        {
            Assert.AreEqual("копейки", Logic.GetWord(3, "копейка", "копейки", "копеек"));
        }
        public void GetWordPennyTest3()
        {
            Assert.AreEqual("копеек", Logic.GetWord(5, "копейка", "копейки", "копеек"));
        }
        public void GetWordPennyTest4()
        {
            Assert.AreEqual("копеек", Logic.GetWord(12, "копейка", "копейки", "копеек"));
        }
        public void GetWordPennyTest5()
        {
          Assert.AreEqual("копейка", Logic.GetWord(21, "копейка", "копейки", "копеек"));
        }


        [TestMethod()]
        public void inIntervalTest0sec()
        {
            Assert.IsTrue(Logic.inInterval(0)); 
        }
        [TestMethod()]
        public void inIntervalTest10000sec()
        {
            Assert.IsTrue(Logic.inInterval(10000));
        }
        [TestMethod()]
        public void inIntervalTest1sec()
        {
            Assert.IsFalse(Logic.inInterval(1));    
        }
        [TestMethod()]
        public void inIntervalTest9999sec()
        {
            Assert.IsFalse(Logic.inInterval(9999));
        }


        [TestMethod()]
        public void ConvertToMoneyTestError()
        {
            string expectedError = "Значение числа должно быть в рамках: [1;9999]", actual;
            actual = Logic.ConvertToMoney(0);
            Assert.AreEqual(expectedError, actual, "Ошибка в определении вхождения в интервал");
        }
        [TestMethod()]
        public void ConvertToMoneyTest()
        {
            string expectedSucces = "56 рублей 56 копеек ", actual;
            actual = Logic.ConvertToMoney(5656);
            Assert.AreEqual(expectedSucces, actual, "При расчете итогового ответа");
        }
    }
}