using System;

namespace CasaDeVideojuegos
{
    class Program
    {
        static void Main(string[] args)
        {
            float importe;
            Console.WriteLine("Ingrese el monto de la venta");
            importe = float.Parse(Console.ReadLine());
            if (importe >= 5000) importe = importe * 0.82F;
            else if (importe >= 1000) importe = importe * 0.90F;
            Console.WriteLine("El importe final es de: $" + importe);
        }
    }
}