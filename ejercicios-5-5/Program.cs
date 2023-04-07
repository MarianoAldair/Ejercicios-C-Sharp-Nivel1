using System;

namespace MaximoParMinimoImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, maxPar = 0, minImpar = 0;
            for(int i = 0; i < 20; i++){
                Console.WriteLine("Ingrese un número");
                n = int.Parse(Console.ReadLine());
                if(n % 2 == 0){
                    if(n > maxPar) maxPar = n;
                };
                if(minImpar == 0) minImpar = n;
                else if(n < minImpar) minImpar = n;
            }
            Console.WriteLine("El máximo de los pares es: " + maxPar + " y el mínimo de los impares es: " + minImpar);
        }
    }
}