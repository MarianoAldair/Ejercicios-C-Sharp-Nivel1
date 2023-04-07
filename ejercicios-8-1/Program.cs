using System;

namespace producto
{
    class Program
    {
        static int producto(int a, int b)
        {
            int resultado;
            resultado = a * b;
            return resultado;
        } 

        static void Main(string[] args)
        {
            int PA, CV, montoTotal;
            Console.WriteLine("Ingrese el precio del artículo");
            PA = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida");
            CV = int.Parse(Console.ReadLine());
            montoTotal = producto(PA, CV);
            Console.WriteLine("El monto total a pagar es: $" + montoTotal + ".");
        }
    }
}