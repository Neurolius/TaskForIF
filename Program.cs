namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            if (input < 1 || input > 9999) {
                Console.WriteLine("Значение числа должно быть в рамках: [1;9999]");
            }
            Console.WriteLine(input/100 + "рублей " + input%100 + "копеек");
        }
    }
}
