using System;

namespace positivoNegativoCero
{
    class Program
    {
        static void positivoNegativoCero(int n, ref int variable)
        {
            if(n > 0) variable = 1;
            else if(n < 0) variable = -1;
            else variable = 0;
        }
        
        static void Main(string[] args)
        {
            int n, m = 0;
            Console.WriteLine("Ingrese un número");
            n = int.Parse(Console.ReadLine());
            positivoNegativoCero(n, ref m);
            Console.WriteLine("Usted ha ingresado el número " + n + " y el resultado de la operación es: " + m + ".");
        }
    }
}