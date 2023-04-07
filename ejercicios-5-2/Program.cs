using System;

namespace MayorDeDiez
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, mayor = 0;
            for(int i = 0; i < 10; i++){
                Console.WriteLine("Ingrese un número");
                n = int.Parse(Console.ReadLine());
                if (n > mayor) mayor = n;
            }
            Console.WriteLine("El mayor de los números es: " + mayor);
        } 
    }
}