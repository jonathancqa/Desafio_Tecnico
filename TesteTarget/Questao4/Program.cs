using System;

namespace Questao4
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal percentualSp, sp = 67.83643M;
            decimal percentualRj, rj = 36.67866M;
            decimal percentualMg, mg = 29.22988M;
            decimal percentualEs, es = 27.16548M;
            decimal percentualOutros, outros = 19.84953M;
            decimal total = sp + rj + mg + es + outros;


            percentualSp = (sp * total) / 100;
            percentualRj = (rj * total) / 100;
            percentualMg = (mg * total) / 100;
            percentualEs = (es * total) / 100;
            percentualOutros = (outros * total) / 100;

            Console.WriteLine($"Percentual de SP: {percentualSp.ToString("N2")}% \n" +
                              $"Percentual de RJ: {percentualRj.ToString("N2")}% \n" +
                              $"Percentual de MG: {percentualMg.ToString("N2")}% \n" +
                              $"Percentual de ES: {percentualEs.ToString("N2")}% \n" +
                              $"Percentual de Outros: {percentualOutros.ToString("N2")}%");
        }
    }
}