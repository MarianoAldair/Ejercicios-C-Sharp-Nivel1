using System;

namespace par
{
    class Program
    {
        static bool par(int n)
        {
            bool resp = false;
            if(n % 2 == 0) resp = true;
            return resp;
        }
        
        static void Main(string[] args)
        {
            int num, contadora = 0;
            for(int i = 0; i < 20; i++){
                Console.WriteLine("Ingrese un número");
                num = int.Parse(Console.ReadLine());
                bool r = par(num);
                if(r) contadora++;
            }
            Console.WriteLine("Usted ha ingresado " + contadora + " números pares.");
        }
    }
}