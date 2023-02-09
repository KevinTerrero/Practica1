using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Especifique que figura desea buscarle el area" +
                "\n Opciones: cuadrado, circulo, triangulo, pentagono, hexagono.");
           string figura= Console.ReadLine();

            if (figura == "cuadrado")
            {
                Console.WriteLine("Introduzca el valor de los lados");
                double lados = Convert.ToDouble(Console.ReadLine());
                double cuadrado = lados * lados;
                Console.WriteLine("El resultado es " + cuadrado);

            }
            else if (figura == "circulo")
            {
                Console.WriteLine("Introduce el radio de la base");
                double radio = Convert.ToDouble(Console.ReadLine());
                double circulo = 3.1416 * (radio * radio);
                Console.WriteLine("El resultado es " + circulo);
            }
            else if (figura == "triangulo")
            {
                Console.WriteLine("Introduce el valor de la base");
                double baseTriangulo = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Introduce el valor de la altura");
                double altura = Convert.ToDouble(Console.ReadLine());
                double triangulo = baseTriangulo * altura / 2;
                Console.WriteLine("El resultado es " + triangulo);

            }
            else if (figura == "pentagono")
            {
                Console.WriteLine("Introduce el valor del perimetro");
                double perimetro = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Introduce el valor de la apotema");
                double apotema = Convert.ToDouble(Console.ReadLine());
                double pentagono = perimetro * apotema / 2;
                Console.WriteLine("El resultado es " + pentagono);

            }
            else if (figura == "hexagono")
            {
                Console.WriteLine("Introduce el valor del perimetro");
                double perimetro = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Introduce el valor de la apotema");
                double apotema = Convert.ToDouble(Console.ReadLine());
                double hexaogono = perimetro * apotema / 2;
                Console.WriteLine("El resultado es " + hexaogono);
            }
            else
            {
                Console.WriteLine("Ponga un valor válido");
            }
            Console.ReadKey();
        }
    }
}
