using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            int fact = 1;
            Console.WriteLine("Por favor introduzca el número con el que desea hacer el factorial");
            int input = Convert.ToInt32(Console.ReadLine());

            for (int i = input; i > 0; i--)
                fact *= i;
            Console.WriteLine("La factorial de " + input + " es " + fact);
            Console.Read();
        }
    }
       
}
