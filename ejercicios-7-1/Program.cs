using System;

namespace DiezNumerosEnterosValorMaximo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] array = new int[10];
            for(int i = 0; i < 10; i++){
                Console.WriteLine("Ingrese un número");
                n = int.Parse(Console.ReadLine());
                array[i] = n;
            }
            int max = 0, posMax = 0;
            for(int j = 0; j < 10; j++){
                if(array[j] > max){
                    max = array[j];
                    posMax = j + 1;
                }
            }
            Console.WriteLine("El valor máximo del vector es: " + max + " y se encuentra ubicado en la posición " + posMax + ".");
        }
    }
}