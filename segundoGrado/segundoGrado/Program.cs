using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace segundoGrado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce n1");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce n2");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce n3");
            double n3 = Convert.ToDouble(Console.ReadLine());

            double ecuacion = (n2 * n2) - (4 * n1 * n3);

            if (ecuacion < 0)
            {
                Console.WriteLine("Esta solución solo funciona con numeros complejos, intente otra vez.");

            }
            else if (ecuacion == 0)
            {
                double a = (-n2) / (2 * n1);
                Console.WriteLine(a.ToString("0.00" ));
            }
            else
            {
                double a = (-n2 + Math.Sqrt(ecuacion)) / (2 * n1);
                double b = (-n2 - Math.Sqrt(ecuacion)) / (2 * n1);
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
        }
    }
}
