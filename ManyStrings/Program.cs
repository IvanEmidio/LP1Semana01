using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string plica = "isto é uma plica - \'";
            string copy = "isto é um copyright - \u03A9";
            string back = "isto é para um back space - \b";



            Console.WriteLine(plica);
            Console.WriteLine(copy);
            Console.WriteLine(back);
        }
    }
}
