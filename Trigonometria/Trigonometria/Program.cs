using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trigonometria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor defina qué función trigonométrica quiere buscar.\n" +
                "Opciones: seno, coseno, tangente, cotangente, secante, cosecante");
            string input = Console.ReadLine();
            Console.WriteLine("Introduzca el valor del angulo");
            double angulo = Convert.ToDouble(Console.ReadLine());

            if (input == "seno")
            {
                double seno = Math.Sin(angulo);
                Console.WriteLine("El resultado de la funcion trigonometrica en radianes es " + seno);
            }
            else if (input == "coseno")
            {
                double coseno = Math.Cos(angulo);
                Console.WriteLine("El resultado de la funcion trigonometrica en radianes es " + coseno);
            }
            else if (input == "tangente")
            {
                double tangente = Math.Tan(angulo);
                Console.WriteLine("El resultado de la funcion trigonometrica en radianes es " + tangente);
            }
            else if (input == "cotangente")
            {
                double cotangente = 1/ Math.Tan(angulo);
                Console.WriteLine("El resultado de la funcion trigonometrica en radianes es " + cotangente);
            }
            else if (input == "secante")
            {
                double secante = 1/ Math.Cos(angulo);
                Console.WriteLine("El resultado de la funcion trigonometrica en radianes es " + secante);
            }
            else if (input == "cosecante")
            {
                double cosecante = 1/ Math.Sin(angulo);
                Console.WriteLine("El resultado de la funcion trigonometrica en radianes es " + cosecante);
            }
            else
            {
                Console.WriteLine("Introduzca un valor valido");

            }
            Console.ReadKey();
        }
    }
}
