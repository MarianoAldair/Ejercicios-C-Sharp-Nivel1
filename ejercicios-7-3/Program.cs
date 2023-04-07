using System;

namespace CadenaDeCaracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            char reemplazar, reemplazo;
            Console.WriteLine("Ingrese una cadena de caracteres");
            cadena = Console.ReadLine();
            Console.WriteLine("Ingrese un caracter a reemplazar");
            reemplazar = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el caracter con el cual se va a reemplazar");
            reemplazo = char.Parse(Console.ReadLine());
            char[] arrayCaracteres = new char[cadena.Length];
            for(int i = 0; i < cadena.Length; i++){
                arrayCaracteres[i] = cadena[i];
            }
            Console.WriteLine("La cadena de caracteres ingresada es: ");
            for(int k = 0; k < arrayCaracteres.Length; k++){
                Console.Write(arrayCaracteres[k]);
            }
            for(int j = 0; j < cadena.Length; j++){
                if(arrayCaracteres[j] == reemplazar) arrayCaracteres[j] = reemplazo;
            }
            Console.WriteLine("");
            Console.WriteLine("La cadena resultante es: ");
            for(int l = 0; l < arrayCaracteres.Length; l++){
                Console.Write(arrayCaracteres[l]);
            }
        }
    }
}