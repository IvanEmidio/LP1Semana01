using System;

namespace AskForInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha um numero inteiro: ");
            string escolha = Console.ReadLine();
            Console.WriteLine("Escolha um numero real: ");
            string escolha1 = Console.ReadLine();

            int numero = int.Parse(escolha);
            float numero1 = float.Parse(escolha1);

            Console.WriteLine($"A soma de ambos os numeros é: {numero + numero1}");
        }
    }
}
