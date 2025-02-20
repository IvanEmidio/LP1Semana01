using System;

namespace VariousTypes
{
    public class Program
    {
        int num = 1;
        uint _num = 2U;
        long _num1 = 3L;
        ulong _num2 = 3UL;
        private static void Main(string[] args)
        {
            Console.WriteLine($"Isto é um inteiro normal: {num}");
            Console.WriteLine($"Isto é um inteiro com literal uint: {_num}");
            Console.WriteLine($"Isto é um inteiro com literal long: {_num1}");
            Console.WriteLine($"Isto é um inteiro com literal ulong: {_num2}");

        }
    }
}
