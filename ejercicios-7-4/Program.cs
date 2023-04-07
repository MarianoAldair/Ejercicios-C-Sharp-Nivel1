using System;

namespace Empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNA = new int[15];
            int[] arrayCV = new int[15];
            for(int n = 0; n < arrayNA.Length; n++){
                arrayNA[n] = 0;
            }
            int NA, CV, NAACT;
            Console.WriteLine("Ingrese el número de artículo");
            NA = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida");
            CV = int.Parse(Console.ReadLine());
            while(NA != 0){
                arrayCV[NA - 1] = CV;
                Console.WriteLine("Ingrese otro número de artículo");
                NA = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad vendida");
                CV = int.Parse(Console.ReadLine());
            }
            int AMV = 0, NAMV = 0;
            for(int i = 0; i < arrayCV.Length; i++){
                if(arrayCV[i] == 0) Console.WriteLine("El artículo número " + (i + 1) + " no registró ventas.");
                if(arrayCV[i] > AMV) NAMV = i + 1;
            }
            Console.WriteLine("Se vendieron " + arrayCV[9] + " unidades del artículo número 10.");
            Console.WriteLine("El número de artículo del artículo más vendido es: " + NAMV + ".");
        }
    }
}