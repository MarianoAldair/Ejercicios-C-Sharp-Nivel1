using System;

namespace MayoresA100
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4;
            Console.WriteLine("Ingrese un número");
            n1 = int.Parse(Console.ReadLine());
            if(n1 > 100) Console.WriteLine("Este número es mayor a 100.");
            Console.WriteLine("Ingrese otro número");
            n2 = int.Parse(Console.ReadLine());
            if(n2 > 100) Console.WriteLine("Este número es mayor a 100.");
            Console.WriteLine("Ingrese otro número");
            n3 = int.Parse(Console.ReadLine());
            if(n3 > 100) Console.WriteLine("Este número es mayor a 100.");
            Console.WriteLine("Ingrese otro número");
            n4 = int.Parse(Console.ReadLine());
            if(n4 > 100) Console.WriteLine("Este número es mayor a 100.");
        }
    }
}