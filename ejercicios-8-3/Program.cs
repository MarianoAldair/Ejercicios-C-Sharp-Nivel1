using System;

namespace primo
{
    class Program
    {
        static bool primo(int n)
        {
            bool resp = false;
            int contadora = 0;
            for(int i = 1; i <= n; i++){
                if(n % i == 0) contadora++;
            }
            if(contadora == 2) resp = true;
            return resp; 
        }
        
        static void Main(string[] args)
        {
            double promedio, count = 0, acum = 0;;
            int n; 
            Console.WriteLine("Ingrese un número");
            n = int.Parse(Console.ReadLine());
            while(n != 0){
                bool respuesta = primo(n);
                if(respuesta){
                    count++;
                    acum += n;
                }
                Console.WriteLine("Ingrese un número");
                n = int.Parse(Console.ReadLine());
            }
            promedio = acum / count;
            Console.WriteLine("Usted ha ingresado " + count + " números primos. El promedio es " + promedio + ".");
        }
    }
}