using System;

namespace CuatroNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4;
            Console.WriteLine("Ingrese un número");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número");
            n4 = int.Parse(Console.ReadLine());
            if(n1 > n2 && n2 > n3 && n3 > n4) Console.WriteLine("Los números se encuentran ordenados de forma decreciente.");
            else Console.WriteLine("Los números no se encuentran ordenados de forma decreciente.");
        }
    }
}