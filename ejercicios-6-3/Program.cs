using System;

namespace ListasNumerosPositivos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, contadora;
            Console.WriteLine("Ingrese un número");
            n = int.Parse(Console.ReadLine());
            while(n > 0){
                contadora = 0;
                while(n != 0 && n > 0){
                    contadora++;
                    Console.WriteLine("Ingrese otro número");
                    n = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Esta lista tiene " + contadora + " números.");
                Console.WriteLine("Ingrese otro número");
                    n = int.Parse(Console.ReadLine());
            }
        }
    }
}