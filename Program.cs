using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APLICACION_2_Unidad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una letra");
            Console.WriteLine("");
            Console.WriteLine("1 - Suma");
            Console.WriteLine("2 - Resta");
            Console.WriteLine("3 - Multiplicación");
            Console.WriteLine("4 - División");
            Console.WriteLine("");

            int numero = 0;
            try { numero = int.Parse(Console.ReadLine()); }
            catch { Console.WriteLine("Introduce solo los numeros indicados."); }

            Console.WriteLine("");
            int numero1 = 0;
            int numero2 = 0;

            switch (numero)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Introduce los numeros.");
                    try
                    {
                        numero1 = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Error");
                    }
                    Console.WriteLine("Introduce los numeros.");
                    try
                    {
                        numero2 = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Error");
                    }
                    int suma = numero1 + numero2;
                    Console.WriteLine("La suma es: " + suma);
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Introduce los numeros.");
                    try
                    {
                        numero1 = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Error");
                    }
                    Console.WriteLine("Introduce los numeros.");
                    try
                    {
                        numero2 = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Error");
                    }
                    int resta = numero1 - numero2;
                    Console.WriteLine("La resta es: " + resta);
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Introduce los numeros.");
                    try
                    {
                        numero1 = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Error");
                    }
                    Console.WriteLine("Introduce los numeros.");
                    try
                    {
                        numero2 = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Error");
                    }
                    int multiplicacion = numero1 * numero2;
                    Console.WriteLine("La multiplicacion es: " + multiplicacion);
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("Introduce los numeros.");
                    try
                    {
                        numero1 = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Error");
                    }
                    Console.WriteLine("Introduce los numeros.");
                    try
                    {
                        numero2 = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Error");
                    }
                    int division = numero1 / numero2;
                    Console.WriteLine("La division es: " + division);
                    break;

                default:
                    Console.WriteLine("Opcion Incorrecta");
                    Console.WriteLine("Selecciona solo los numeros indicados.");
                    Console.ReadKey();
                    return;
            }

            Console.ReadKey();
        }
    }
}
