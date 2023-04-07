using System;

namespace TresNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3;
            double promedio;
            Console.WriteLine("Ingrese la nota del primer parcial del alumno");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del segundo parcial del alumno");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del tercer parcial del alumno");
            n3 = float.Parse(Console.ReadLine());
            promedio = (n1 + n2 + n3) / 3;
            Console.WriteLine("El promedio final del alumno es: " + promedio.ToString("0.00"));
        }
    }
}