using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Questao3.Models
{
    public class Venda
    {
        public Venda(int dia, decimal valor)
        {
            Dia = dia;
            Valor = valor;
        }
        
        [JsonProperty("dia")]
        public int Dia { get; set; }

        [JsonProperty("valor")]
        public decimal Valor { get; set; }
    }
}