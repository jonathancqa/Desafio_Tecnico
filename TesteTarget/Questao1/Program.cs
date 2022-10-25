using System;

namespace Questao1
{
    class Program
    {
        static void Main(string[] args)
        {
            int indice = 13, soma = 0, k = 0;
            while (k < indice)
            {
                k = k + 1;
                soma = soma + k;
            }
            Console.WriteLine($"Resultado é {soma}"); // Resultado da soma é 91.
        }
    }
}