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
        public void GetWordRubleTest()
        {
            for (int i = 1; i < 100; i++)
            {
                string expected;

                int number = i % 100;
                int lastDigit = number % 10;

                if (number >= 11 && number <= 19)
                    expected = " рублей ";
                else if (lastDigit == 1)
                    expected = " рубль ";
                else if (lastDigit >= 2 && lastDigit <= 4)
                    expected = " рубля ";
                else
                    expected = " рублей ";

                string actual = Logic.GetWord(i, " рубль ", " рубля ", " рублей ");

                Assert.AreEqual(expected, actual, $"Ошибка при числе {i}");
            }

        }

        [TestMethod()]
        public void GetWordPennyTest()
        {
            for (int i = 0; i < 100; i++)
            {
                string expected;

                int number = i % 100;
                int lastDigit = number % 10;

                if (number >= 11 && number <= 19)
                    expected = " копеек ";
                else if (lastDigit == 1)
                    expected = " копейка ";
                else if (lastDigit >= 2 && lastDigit <= 4)
                    expected = " копейки ";
                else
                    expected = " копеек ";

                string actual = Logic.GetWord(i, " копейка ", " копейки ", " копеек ");

                Assert.AreEqual(expected, actual, $"Ошибка при числе {i}");
            }
        }

        [TestMethod()]
        public void inIntervalTest()
        {

            for (int i = 0; i < 10000; i++)
            {
                bool expected = i < 1 || i > 9999;
                bool result = Logic.inInterval(i);
                Assert.AreEqual(expected, result, $"Ошибка при числе {i}");
            }
        }

        [TestMethod()]
        public void ConvertToManyTest()
        {
            int[] errorNumbers = { 0, 10000 };
            string expectedError = "Значение числа должно быть в рамках: [1;9999]"
                    , expectedSuccesful = "56 рублей 56 копеек ", actual;

            foreach (var n in errorNumbers)
            {
                actual = Logic.ConvertToMany(n);
                 Assert.AreEqual(expectedError, actual, "Ошибка в определении вхождения в интервал");
            }
            actual = Logic.ConvertToMany(5656);
            Assert.AreEqual(expectedSuccesful, actual, "При расчете итогового ответа");
            
        }
    }
}