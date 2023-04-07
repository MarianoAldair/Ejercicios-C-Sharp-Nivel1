using System;

namespace PromedioEdades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, b = 0;
            Console.WriteLine("Ingrese un número");
            n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++){
                if(n % i == 0){
                    b++;
                }
            }
            if(b == 2) Console.WriteLine("El número ingresado es primo.");
            else Console.WriteLine("El número ingresado no es primo.");
        }
    }
}