namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string ruble = " рубля ", penny = " копеек ";
            if (input < 1 || input > 9999)
            {
                Console.WriteLine("Значение числа должно быть в рамках: [1;9999]");
            }
            else
            {
                //Рубли
                if(input / 100 !=11 && input/100 == 1)
                {
                    ruble = " рубль ";
                }
                if((input / 100)%10 >=5 && (input / 100)%10 <=9 || (input / 100) % 10 ==0 || ((input / 100) >= 11 && (input / 100) <= 20))
                {
                    ruble = " рублей ";
                }

                //Копейки
                if (input % 100 != 11 && input % 100 == 1)
                {
                    ruble = " рубль ";
                }
                if ((input % 100) % 10 >= 5 && (input % 100) % 10 <= 9 || (input / 100) % 10 == 0 || ((input / 100) >= 11 && (input / 100) <= 20))
                {
                    ruble = " рублей ";
                }
                Console.WriteLine(input / 100 + ruble + input % 100 + penny);
            }
        }
    }
}