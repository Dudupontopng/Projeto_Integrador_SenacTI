using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Integrador.Modelos
{
    public class Partida
    {
        public DateTime DataHora { get; set; }
        public int Pontuacao { get; set; }
        public int TotalPerguntas { get; set; }
        public string Desempenho { get; set; } 
    }
}
