using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1
{
    internal class HelloWorld
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para calcular el área de un triángulo.");
            Console.WriteLine("Introduzca el primer número.");
            float baseT = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo número");
            float altuT = float.Parse(Console.ReadLine());
            Console.WriteLine("Tu Resultado es =" + ((baseT * altuT)/2));
            //Espera un valor del teclado
            Console.ReadKey();
        }
    }
}
