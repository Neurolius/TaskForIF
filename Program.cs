namespace ConsoleApp1
{
    internal class Program
    {
        public static string GetWord(int number, string form1, string form2, string form3)
        {
           
            number = number % 100;
            int lastDigit = number % 10;

            if (number >= 11 && number <= 19)
                return form3;

            if (lastDigit == 1)
                return form1;

            if (lastDigit >= 2 && lastDigit <= 4)
                return form2;

            return form3;
        }

        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string ruble, penny;
            if (input < 1 || input > 9999)
            {
                Console.WriteLine("Значение числа должно быть в рамках: [1;9999]");
            }
            else
            {
                ruble = GetWord(input / 100, " рубль ", " рубля ", " рублей ");
                penny = GetWord(input % 100, " копейка ", " копейки ", " копеек ");
                Console.WriteLine(input / 100 + ruble + input % 100 + penny);
            }
        }
    }
}