using System;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insira um numero inteiro: ");
            string _int = Console.ReadLine();
            int a = int.Parse(_int);
            Console.WriteLine("Insira um numero real: ");
            string _float = Console.ReadLine();
            float b = float.Parse(_float);
            Console.WriteLine($"A soma dos 2 valores é {a+b}");
        }
    }
}
