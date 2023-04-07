using System;

namespace NegocioDesinfectante
{
    class Program
    {
        static void Main(string[] args)
        {
            float impTotal, litros, impConDesc;
            Console.WriteLine("Ingrese el importe total de la venta");
            impTotal = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los litros vendidos");
            litros = int.Parse(Console.ReadLine());
            if(litros > 500) {
                impConDesc = impTotal * 0.75F;
            } else if(litros > 300) {
                impConDesc = impTotal * 0.85F;
            } else if(litros > 100) {
                impConDesc = impTotal * 0.90F;
            } else impConDesc = impTotal;
            Console.WriteLine("El importe final es: $" + impConDesc);
        }
    }
}