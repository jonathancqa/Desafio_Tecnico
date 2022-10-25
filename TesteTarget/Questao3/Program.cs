using Questao3.Models;
using Newtonsoft.Json;
using System;

namespace Questao3
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal maiorFaturamento = 0, menorFaturamento = 0;
            decimal mediaFaturamento = 0, total = 0, mediaDiaria = 0;
            int contador = 0;

            string faturamento = File.ReadAllText("dados.json");

            List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(faturamento);

            int quantidadeRemovido = listaVenda.RemoveAll(item => item.Valor == 0); // Remove os dias e valores igual á 0

            listaVenda.ForEach(venda =>
            {

                //Console.WriteLine($"Dia: {venda.Dia}, Valor: {venda.Valor}"); // Exibe os dias e valores

                if (venda.Valor > maiorFaturamento)
                {
                    maiorFaturamento = venda.Valor;

                }
                if (venda.Valor < maiorFaturamento)
                {
                    menorFaturamento = venda.Valor;
                }

                contador = listaVenda.Count();
                total = total + venda.Valor;
                mediaFaturamento = total / contador;

                if (mediaFaturamento > venda.Valor)
                {
                    mediaDiaria++;
                }
            });

            Console.WriteLine($"Maior Faturamento: {maiorFaturamento}");
            Console.WriteLine($"Menor Faturamento: {menorFaturamento}");
            Console.WriteLine($"Média de Faturamento {mediaFaturamento}");
            Console.WriteLine($"Dias em que o valor diário foi superior a média mensal: {mediaDiaria}");

        }
    }
}