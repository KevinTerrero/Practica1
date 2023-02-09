using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJCLASE01
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Diga qué temperatura desea convertir");
            string temp = Console.ReadLine();
            temp = temp.ToLower();
            if (temp == "celsius")
            {
                Console.WriteLine("Diga a qué temperatura desea convertir el valor de celsius");
                string temp2 = Console.ReadLine();
                temp2 = temp2.ToLower();
                if (temp2 == "farenheit") {
                    Console.WriteLine("Diga el valor de celsius");
                    int celsius = Convert.ToInt32(Console.ReadLine());
                    double CToF = (celsius * 1.8) + 32;
                    Console.WriteLine(CToF);
                
                }
                else if(temp2 == "kelvin")
                {
                    Console.WriteLine("Diga el valor de celsius");
                    int celsius = Convert.ToInt32(Console.ReadLine());
                    double CToK = (celsius + 273.15);
                    Console.WriteLine(CToK);

                }

            } else if (temp == "farenheit")
            {
                Console.WriteLine("Diga a qué temperatura desea convertir el valor de farenheit");
                string temp2 = Console.ReadLine();
                temp2 = temp2.ToLower();
                if (temp2 == "celsius")
                {
                    Console.WriteLine("Diga el valor de farenheit");
                    int farenheit = Convert.ToInt32(Console.ReadLine());
                    double FtoC = 5/9 *(farenheit-32);
                    Console.WriteLine(FtoC);

                }
                else if (temp2 == "kelvin")
                {
                    Console.WriteLine("Diga el valor de farenheit");
                    int farenheit = Convert.ToInt32(Console.ReadLine());
                    double FToK = (farenheit -32 ) * 5/9 + 273.15;
                    Console.WriteLine(FToK);

                }
                else if (temp == "kelvin")
                {
                    Console.WriteLine("Diga a qué temperatura desea convertir el valor de kelvin");
                    string temp3 = Console.ReadLine();
                    temp3 = temp3.ToLower();
                    if (temp3 == "celsius")
                    {
                        Console.WriteLine("Diga el valor de kelvin");
                        int kelvin = Convert.ToInt32(Console.ReadLine());
                        double KtoC = kelvin - 273.15;
                        Console.WriteLine(KtoC);

                    }
                    else if (temp3 == "farenheit")
                    {
                        Console.WriteLine("Diga el valor de kelvin");
                        int kelvin = Convert.ToInt32(Console.ReadLine());
                        double KToF = 1.8 * (kelvin - 273.15) + 32;
                        Console.WriteLine(KToF);

                    }
                   

                }
                else{
                    Console.WriteLine("Introduzca un valor valido");
                }

                    Console.Read();


        }
    }
}
