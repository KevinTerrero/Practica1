using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monedas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var aDar = new[]{0,0,0,0,0,0,0,0,0,0 };
            var monedas = new[] {2000, 1000, 500, 200, 100, 50, 25, 10, 5, 1};

            Console.WriteLine("Introduzca la cantidad en pesos");
            int input = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < monedas.Length; i++)
            {
                var billete = monedas[i];
                while (input >= billete)
                {
                    input -= billete;
                    aDar[i] += 1;
                }
                
            }

            foreach (var item in aDar)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
