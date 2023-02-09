using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calificacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, introduzca su primera nota.");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Por favor, introduzca su segunda nota.");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Por favor, introduzca su tercera nota.");
            int n3 = Convert.ToInt32(Console.ReadLine());

            int nota = (n1 + n2 + n3) / 3;

            if (nota >= 90)
            {
                Console.WriteLine("Nota literal es A");
            }
            else if (nota >= 80)
            {
                Console.WriteLine("Nota literal es B");

            }
            else if (nota >= 70)
            {
                Console.WriteLine("Nota literal es C");

            }
            else if (nota >= 60)
            {
                Console.WriteLine("Nota literal es D");

            }
            else
            {
                Console.WriteLine("Nota literal es F");

            }
            Console.ReadKey();
        }
    }
}
