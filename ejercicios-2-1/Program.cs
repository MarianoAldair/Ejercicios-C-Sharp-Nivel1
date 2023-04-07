using System;

namespace SumaDosNumeros {

    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resultado;
            Console.WriteLine("Ingrese un número");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número");
            n2 = int.Parse(Console.ReadLine());
            resultado = n1 + n2;
            Console.WriteLine("El resultado de la operación es: " + resultado);
        }
    }
}