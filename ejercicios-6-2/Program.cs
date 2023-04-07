using System;

namespace CincoListas
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, contadoraPares, contadoraImpares, porcentajeImpares = 0, porcentaje, numGrupo = 0, numGrupoMax = 0, mayor = 0, bandera, contadoraGruposOrdenados = 0;
            for(int i = 0; i < 5; i++){
                Console.WriteLine("Ingrese un número");
                n = int.Parse(Console.ReadLine());
                numGrupo++;
                bandera = 0;
                contadoraPares = 0;
                contadoraImpares = 0;
                while(n != 0){
                    mayor = n;
                    if(n % 2 == 0) contadoraPares++;
                    else contadoraImpares++;
                    Console.WriteLine("Ingrese otro número");
                    n = int.Parse(Console.ReadLine());
                    if(n < mayor){
                        bandera++;
                        mayor = n;
                    }
                }
                porcentaje = (contadoraImpares * 100) / (contadoraPares + contadoraImpares);
                if(porcentaje > porcentajeImpares){
                    porcentajeImpares = porcentaje;
                    numGrupoMax = numGrupo;
                };
                if(bandera == contadoraPares + contadoraImpares) contadoraGruposOrdenados++;
            }
            Console.WriteLine("El número de grupo con mayor porcentaje de números impares es el número " + numGrupoMax + ".");
            Console.WriteLine("Hay " + contadoraGruposOrdenados + " grupos formados por todos sus números ordenados de mayor a menor.");
        }
    }
}