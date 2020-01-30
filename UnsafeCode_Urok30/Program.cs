using System;

namespace UnsafeCode_Urok30
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                int i = 30;

                int* address = &i; // Тип* - Разименование

                Console.WriteLine(*address); // *Имя - 
                Console.WriteLine((long)address);

                Console.WriteLine();

                int a = 5;
                int b = 7;

                Console.WriteLine("b= " + *(&a + 1));  // int = 4 байта

                Calc(a, &b);

                Console.WriteLine(a);
                Console.WriteLine(b);

                Console.WriteLine();

                int* address2 = address + 4;
                *address2 = 777;
                Console.WriteLine(*address2);

                Console.WriteLine();

                int** adr = &address;
                Console.WriteLine((long)adr);
                Console.WriteLine((long)*adr);
                Console.WriteLine(**adr);

                Console.ReadLine();
            }
        }

        static unsafe void Calc(int i, int * j)
        {
            i = 500;
            *j = 700;
        }

        static void Calc(int i, ref int j)
        {

        }
    }
}
