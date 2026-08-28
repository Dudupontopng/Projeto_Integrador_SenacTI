using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Integrador.Modelos
{
    public class HistoricoExibicao
    {

        public string Tema { get; set; }

        public bool Acertou { get; set; }

        public int Pontos { get; set; }

       
        public string Resultado => Acertou ? "Acertou" : "Errou";
    }
}
