using System;

namespace MarcaDeComputadoras
{
    class Program
    {
        static void Main(string[] args)
        {
            int procesador, RAM, extDisco, montoFinal;
            montoFinal = 0;
            Console.WriteLine("Seleccione su procesador: 1) i5 2) i7 3) i9.");
            procesador = int.Parse(Console.ReadLine());
            Console.WriteLine("Seleccione su memoria RAM: 1) 8RAM 2) 16RAM 3) 32RAM.");
            RAM = int.Parse(Console.ReadLine());
            Console.WriteLine("¿Desea extender su disco de 500GB a 1TB? 1) Extender 0) No extender.");
            extDisco = int.Parse(Console.ReadLine());
            switch(procesador){
                case 1:
                    switch(RAM){
                        case 1: montoFinal = 800;
                        break;
                        case 2: montoFinal = 900;
                        break;
                        case 3: montoFinal = 1200;
                        break;
                    }
                break;
                case 2:
                    switch(RAM){
                        case 1: montoFinal = 900;
                        break;
                        case 2: montoFinal = 1000;
                        break;
                        case 3: montoFinal = 1400;
                        break;
                    }
                break;
                case 3:
                    switch(RAM){
                        case 1: montoFinal = 1200;
                        break;
                        case 2: montoFinal = 1400;
                        break;
                        case 3: montoFinal = 2000;
                        break;
                    }
                break;
            } 
            if(extDisco == 1) montoFinal += 300;
            Console.WriteLine("El monto final de la máquina seleccionada es: $" + montoFinal);     
        }
    }
}