using System;

namespace DiezNumerosEnterosPromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, acumuladora = 0;
            int[] array = new int[10];
            float promedio;
            for(int i = 0; i < 10; i++){
                Console.WriteLine("Ingrese un número");
                n = int.Parse(Console.ReadLine());
                array[i] = n;
                acumuladora += array[i];
            }
            promedio = acumuladora / 10;
            for(int j = 0; j < 10; j++){
                if(array[j] > promedio)
                Console.WriteLine("El número " + array[j] + " es mayor al promedio de los números ingresados.");
            }
        }
    }
}