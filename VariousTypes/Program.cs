﻿using System;

namespace VariousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte sb = 1;
            short st = 2;
            int inteiro = 4;
            long lg = 300L;
            byte bite = 4;
            ushort ust = 60;
            uint uinteiro = 8U;
            ulong ulg = 700UL;
            char caracter = 'a';
            char caracter1 = '\u260e';
            char caracter2 = '\u2708';
            char caracter3 = '\u2605';


            ///Variaveis Reais 
            
            float ft = 3.17f;
            double db = 3.1415;
            decimal dec = 3.1415m;


            Console.WriteLine(sb);
            Console.WriteLine(st);
            Console.WriteLine(inteiro);
            Console.WriteLine(lg);
            Console.WriteLine(bite);
            Console.WriteLine(ust);
            Console.WriteLine(uinteiro);
            Console.WriteLine(ulg);
            Console.WriteLine(caracter);
            Console.WriteLine(caracter1);
            Console.WriteLine(caracter2);
            Console.WriteLine(caracter3);


            Console.WriteLine(ft);
            Console.WriteLine(db);
            Console.WriteLine(dec);


            ///Tipo Booleano
            
            if(inteiro > 2)
                Console.WriteLine(true);

            if(2 > inteiro)
                Console.WriteLine(false);

        }
    }
}
