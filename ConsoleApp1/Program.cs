namespace ConsoleApp1
{
    public class Logic
    {
        public static string GetWord(int number, string form1, string form2, string form3)
        {
           
            number = number % 100;
            int LastDigit = number % 10;

            if (number >= 11 && number <= 19)
                return form3;

            if (LastDigit == 1)
                return form1;

            if (LastDigit >= 2 && LastDigit <= 4)
                return form2;

            return form3;
        }

        public static bool inInterval(int number)
        {
            return number < 1 || number > 9999;
        }

        public static string ConvertToMany(int input) {

            if (inInterval(input))
            {
                 return "Значение числа должно быть в рамках: [1;9999]";
            }
            else
            {
                string ruble = GetWord(input / 100, " рубль ", " рубля ", " рублей "),
                    penny = GetWord(input % 100, " копейка ", " копейки ", " копеек ");
                return input / 100 + ruble + input % 100 + penny;
            }
        }
    }

    internal class Program
    {
     
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string result = Logic.ConvertToMany(input);
            Console.WriteLine(result);
        }
    }
}