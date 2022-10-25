using System;

namespace Questao5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Digite uma palavra para ser invertida ===");
            string texto = Console.ReadLine();

            char[] letras;
            letras = texto.ToCharArray();
            char[] textoInvertido = new char[texto.Length];
            int j = 0;

            for (int i = letras.Length - 1; i >= 0; i--)
            {
                textoInvertido[j] = letras[i];
                j++;
            }

            string palavra = new string(textoInvertido);

            Console.WriteLine($"Palavra digitada: {texto}");
            Console.WriteLine($"Palavra invertida: {palavra}");
        }
    }
}