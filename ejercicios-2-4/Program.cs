using System;

namespace CasaDeComputacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int sueldoFijo = 15000;
            double totalFact;
            double sueldoTotal;
            Console.WriteLine("Ingrese el total facturado por el empleado");
            totalFact = float.Parse(Console.ReadLine());
            sueldoTotal = sueldoFijo + (totalFact * 0.05);
            Console.WriteLine("El sueldo total a pagar al empleado es de: $" + sueldoTotal);
        }
    }
}