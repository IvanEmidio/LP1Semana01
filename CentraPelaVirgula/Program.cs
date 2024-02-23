using System;

namespace CentraPelaVirgula
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Indica-me 4 numeros reais: ");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            string d = Console.ReadLine();

            double num1 = double.Parse(a);
            double num2 = double.Parse(b);
            double num3 = double.Parse(c);
            double num4 = double.Parse(d);

            Console.WriteLine($"{num1,6:f2}\n{num2,6:f2}\n{num3,6:f2}\n{num4,6:f2}");
        }
    }
}
