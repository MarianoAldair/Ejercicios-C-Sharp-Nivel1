using System;

namespace PromedioEdades
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad, contadora, acumuladora;
            contadora = 0;
            acumuladora = 0;
            float promedio;
            for(int i = 0; i < 20; i++){
                Console.WriteLine("Ingrese una edad");
                edad = int.Parse(Console.ReadLine());
                if (edad > 18){
                    contadora++;
                    acumuladora += edad;
                }
            }
            promedio = acumuladora / contadora;
            Console.WriteLine("El promedio de edad de las " + contadora + " personas mayores a 18 años es: " + promedio.ToString("0.00"));
        }
    }
}