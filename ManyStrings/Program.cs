using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            double xx = 1.23456;
            int ii = 19;

            Console.WriteLine($"Duas Casas Decimais: {xx:f2}");
            Console.WriteLine($"Uma Casa Decimal e Percentagem: {xx:p1}");

            Console.WriteLine($"Hexadecimal: {ii:x}");
            Console.WriteLine($"Moeda: {ii:c}");





            string plica = "isto é uma plica - \'";
            string copy = "isto é um copyright - \u03A9";
            string back = "isto é para um back space - \b";


            Console.WriteLine(plica);
            Console.WriteLine(copy);
            Console.WriteLine(back);

            string primeira = "dia ";
            int num = 10;
            string segunda = " vou sair.";
            int num2 = 5;

            ///concatenaçao
            Console.WriteLine(primeira + num + segunda);
            Console.WriteLine("hoje vou comprar "+ num2 + " cartas para o meu baralho.");
            ///interpolaçao 
            Console.WriteLine($"a soma de {num} mais {num2} vai dar {num + num2}");
            Console.WriteLine($"a subtraçao de {num} menos {num2} vai dar {num - num2}");
        }
    }
}
