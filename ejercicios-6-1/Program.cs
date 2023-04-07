using System;

namespace DiezNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, contadora = 0;
            for(int i = 0; i < 10; i++){
                Console.WriteLine("Ingrese un número");
                n = int.Parse(Console.ReadLine());
                int b = 0;
                for(int j = 1; j <= n; j++){
                    if(n % j == 0) b++;
                }
                if(b == 2) contadora++;
            }
            Console.WriteLine("Usted ha inresado " + contadora + " números primos.");
        }
    }
}