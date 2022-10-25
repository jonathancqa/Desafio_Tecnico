using System;
namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numAnterior = 0, numAtual = 1, soma = 0;
            Console.WriteLine("===== SEQUÊNCIA FIBONACCI =====");
            Console.Write("Digite um numero: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write($"{numAnterior} {numAtual} ");

            while (soma < num)
            {
                soma = numAnterior + numAtual;
                Console.Write(soma + " ");
                numAnterior = numAtual;
                numAtual = soma;
            }

            Console.WriteLine("");
            if (num == soma)
            {
                Console.WriteLine($"O numero {num} pertence a sequência Fibonacci.");
            }
            else
            {
                Console.WriteLine($"O numero {num} não pertence a sequência Fibonacci.");
            }
        }
    }
}