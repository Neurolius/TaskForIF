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

    }
}