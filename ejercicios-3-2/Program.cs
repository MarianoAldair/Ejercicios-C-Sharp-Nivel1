using System;

namespace PositivoNegativoCero
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Ingrese un número");
            n = int.Parse(Console.ReadLine());
            if (n > 0) Console.WriteLine("El número es positivo.");
            else if(n != 0) Console.WriteLine("El número es negativo");
            else Console.WriteLine("El número es cero");
        }
    }
}