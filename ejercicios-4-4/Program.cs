using System;

namespace TresNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            Console.WriteLine("Ingrese un número");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número");
            n3 = int.Parse(Console.ReadLine());
            if(n1 + n2 > n2 * n3) 
            Console.WriteLine("El resultado de la suma del primer número con el segundo es mayor al producto del segundo con el tercero.");

        }
    }
}