using System;

namespace Estructura_Rep_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = 1;

            do
            {
                if (x <= 10)
                {
                    Console.Write(x);
                    Console.Write(" - ");
                    x = x + 1;
                }
            }
            while (x != 1);
            Console.ReadKey(); 
             

        }    
    }

}
