using System;

namespace VariousTypes
{
    public class Program
    {
    
        private static void Main(string[] args)
        {
            int num = 1;
            uint _num = 2U;
            long _num1 = 3L;
            ulong _num2 = 3UL;

            char _backspace = '\u0008';
            char _tab = '\u0009';

            float _float = 3.2f;
            double _double = 3.2345;
            decimal _decimal = 4.436534m;

            bool _bool = true;
            bool _bool2 = false;


            Console.WriteLine($"Isto é um inteiro normal: {num}");
            Console.WriteLine($"Isto é um inteiro com literal uint: {_num}");
            Console.WriteLine($"Isto é um inteiro com literal long: {_num1}");
            Console.WriteLine($"Isto é um inteiro com literal ulong: {_num2}");

            Console.WriteLine($"Isto é um character com Unicode: {_backspace}");
            Console.WriteLine($"Isto é um character com Unicode: {_tab}");

            Console.WriteLine($"Isto é um float com o seu literal: {_float}");
            Console.WriteLine($"Isto é um Double: {_double}");
            Console.WriteLine($"Isto é um Decimal com o seu literal: {_decimal}");

            Console.WriteLine($"Isto é uma variavel bool: {_bool}");
            Console.WriteLine($"Isto é outra variavel bool: {_bool2}");

        }
    }
}
