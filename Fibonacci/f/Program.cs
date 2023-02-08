using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class Fibonacci
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un número para hacer la serie fibonacci");
            int input = Convert.ToInt32(Console.ReadLine());

            int x = 0;
            int y = 0;
            int cant = 0;

            if (input <= 0)
            {
                Console.WriteLine("Introduzca un número mayor a 0");

            }
            else if (input == 1)
            {
                Console.WriteLine("La serie fibonacci de 1 es " + x);

            }
            else
            {
                while (cant < input)
                {
                    Console.WriteLine(x);
                    int suma = x + y;
                    x = y;
                    y = suma;
                    cant += 1;
                }
            }

        }
    }
}
