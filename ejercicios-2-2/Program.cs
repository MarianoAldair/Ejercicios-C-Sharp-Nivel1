using System;

namespace Cubo{

    class Program
    {

        static void Main(string[] args)
        {
            int n1, resultado;
            Console.WriteLine("Ingrese un número para obtener su valor al cubo");
            n1 = int.Parse(Console.ReadLine());
            resultado = n1 * n1 * n1;
            Console.WriteLine("El cubo del número es: " + resultado);
        }
    }
}