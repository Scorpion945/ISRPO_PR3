using System.Net.Http.Headers;
using pr3;

namespace pr3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите А:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите B:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите операцию:");
            char c = Convert.ToChar(Console.ReadLine());
            Class1 clas = new Class1();
            switch (c)
            {
                case '+':
                    Console.WriteLine($"a + b = {clas.Plus(a, b)}");
                    break;
                case '-':
                    Console.WriteLine($"a - b = {clas.Minus(a, b)}");
                    break;
                case '/':
                    Console.WriteLine($"a / b = {clas.Div(a, b)}");
                    break;
                case '*':
                    Console.WriteLine($"a * b = {clas.Multi(a, b)}");
                    break;
            }
            Console.ReadKey();
        }
    }
}