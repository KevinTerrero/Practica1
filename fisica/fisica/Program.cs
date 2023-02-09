using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fisica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que desea calcular?\n" +
                "Opciones: velocidad, tiempo, distancia");
            string input = Console.ReadLine();
            double velocidad;
            double tiempo;
            double distancia;
            if (input == "velocidad")
            {
                Console.WriteLine("Introduzca el tiempo");
                tiempo = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Introduzca la distancia");
                distancia = Convert.ToDouble(Console.ReadLine());
                velocidad = distancia / tiempo;
                Console.WriteLine("La velocidad es " + velocidad);
            }
            else if (input == "tiempo")
            {
                Console.WriteLine("Introduzca el distancia");
                distancia = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Introduzca la velocidad");
                velocidad = Convert.ToDouble(Console.ReadLine());
                tiempo = distancia / velocidad;
                Console.WriteLine("El tiempo es " + tiempo);
            }
            else if (input == "distancia")
            {
                Console.WriteLine("Introduzca el tiempo");
                tiempo = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Introduzca la velocidad");
                velocidad = Convert.ToDouble(Console.ReadLine());
                distancia = velocidad * tiempo;
                Console.WriteLine("La distancia es " + distancia);
            }
            else
            {
                Console.WriteLine("Introduzca un valor valido");
            }
            Console.ReadKey();
        }
    }
}
