using System;

namespace VariousTypes
{
    public class Program
    {
        static int num = 1;
        static uint _num = 2U;
        static long _num1 = 3L;
        static ulong _num2 = 3UL;
        static char _backspace = '\u0008';
        static char _tab = '\u0009';

        static float _float = 3.2f;
        static double _double = 3.2345;

        static decimal _decimal = 4.436534m;

        private static void Main(string[] args)
        {
            Console.WriteLine($"Isto é um inteiro normal: {num}");
            Console.WriteLine($"Isto é um inteiro com literal uint: {_num}");
            Console.WriteLine($"Isto é um inteiro com literal long: {_num1}");
            Console.WriteLine($"Isto é um inteiro com literal ulong: {_num2}");

            Console.WriteLine($"Isto é um character com Unicode: {_backspace}");
            Console.WriteLine($"Isto é um character com Unicode: {_tab}");

            Console.WriteLine($"Isto é um float com o seu literal: {_float}");
            Console.WriteLine($"Isto é um Double: {_double}");
            Console.WriteLine($"Isto é um Decimal com o seu literal: {_decimal}");


        }
    }
}
