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
            //To asign a variable
            const float PI = 3.1416f;
            //This is how you could asign a variable in a program
            int num1=0;
            Console.WriteLine("Introduce el primer número:");

            //Console Read Line gets the text input.
            int num2 =int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número:");

            int num3 = int.Parse(Console.ReadLine());
            //Con + concatenas el texto con el resultado
            Console.WriteLine("El resultado es :" + (num2 + num3));
            //Al usar , se utiliza como parametro
            Console.WriteLine("Pi es igual a "+ PI);

            //Indicar parametros a mostrar con {} dentro de los argumentos del método
            Console.WriteLine("El valor de la constante es: {0}", PI);


            Console.ReadKey();
        }
    }
}
