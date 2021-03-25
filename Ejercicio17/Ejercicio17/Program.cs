using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer número:");
            if(!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.Write("Debe ingresar un número. Pulse una tecla para salir.");
                Console.ReadKey();
                return;
            }
            Console.Write("Ingrese el segundo número:");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.Write("Debe ingresar un número. Pulse una tecla para salir.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
            Console.WriteLine($"{num1} ^ {num2} = {Math.Pow(num1, num2)}");
            Console.ReadKey();
        }
    }
}
