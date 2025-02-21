using System;
using System.Globalization;

namespace Percentagem
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.CurrentCulture;
            Console.WriteLine("Insere 4 números reais entre 0 e 1: ");
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
            string num3 = Console.ReadLine();
            string num4 = Console.ReadLine();
            float _num1 = float.Parse(num1);
            float _num2 = float.Parse(num2);
            float _num3 = float.Parse(num3);
            float _num4 = float.Parse(num4);
            Console.WriteLine($"{_num1,7:p2}");
            Console.WriteLine($"{_num2,7:p2}");
            Console.WriteLine($"{_num3,7:p2}");
            Console.WriteLine($"{_num4,7:p2}");

        }
    }
}
