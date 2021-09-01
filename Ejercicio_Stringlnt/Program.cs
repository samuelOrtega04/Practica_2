using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Stringlnt
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, edad;
            Console.WriteLine("Escribe tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Escribe tu edad");
            edad = Console.ReadLine();
            Console.WriteLine("Te llamas " + nombre + "Y tienes:" + edad);
            Console.WriteLine("Presiona Cualquier tecla para continuar");
            Console.ReadKey();

        }
    }
}
