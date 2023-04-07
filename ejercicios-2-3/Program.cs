using System;

namespace KilometrosYVelocidad
{

    class Program
    {
        static void Main(string[] args)
        {
            float kms, velocidad;
            float tiempoAprox;
            Console.WriteLine("Ingrese los kilómetros que separan las ciudades");
            kms = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la velocidad promedio de su vehículo");
            velocidad = int.Parse(Console.ReadLine());
            tiempoAprox = (kms * 1) / velocidad;
            Console.WriteLine("Le llevará aproximadamente " + tiempoAprox.ToString("0.00") + " horas hacer su viaje");
        }
    }
}