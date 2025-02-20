using System;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string star = "\u2605";
            string heart = "\u279C";
            string flag = "\u2690";

            Console.WriteLine("Isto é uma estrela: " + star);
            Console.WriteLine("Isto é um coraçao: " + heart);
            Console.WriteLine("Isto é uma bandeira: " + flag);
        }
    }
}
