using System;

namespace MenorDeCuatro
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, menor;
            Console.WriteLine("Ingrese un número");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número");
            n4 = int.Parse(Console.ReadLine());
            if(n1 < n2 && n1 < n3 && n1 < n4) menor = n1;
            else if(n2 < n3 && n2 < n4) menor = n2;
            else if(n3 < n4) menor = n3;
            else menor = n4; 
            Console.WriteLine("El menor de los números es: " + menor);
        }
    }
}