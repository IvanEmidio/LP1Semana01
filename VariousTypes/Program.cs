using System;

namespace VariousTypes
{
    public class Program
    {
        int num = 1;
        uint _num = 2U;
        long _num1 = 3L;
        ulong _num2 = 3UL;
        char _backspace = '\u0008'
        char _tab = '\u0009'

        private static void Main(string[] args)
        {
            Console.WriteLine($"Isto é um inteiro normal: {num}");
            Console.WriteLine($"Isto é um inteiro com literal uint: {_num}");
            Console.WriteLine($"Isto é um inteiro com literal long: {_num1}");
            Console.WriteLine($"Isto é um inteiro com literal ulong: {_num2}");

            Console.WriteLine($"Isto é um character com Unicode: {_backspace}");
            Console.WriteLine($"Isto é um character com Unicode: {_tab}");


        }
    }
}
