using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Integrador.Modelos
{
    public class Alternativa
    {
        public Alternativa() { }

        public Alternativa(int id, int perguntaId, string texto, bool isCorreta)
        {
            Id = id;
            PerguntaId = perguntaId;
            Texto = texto;
            IsCorreta = isCorreta;
        }
        public Alternativa(string texto, int perguntaId, bool isCorreta)
        {
            
           
            Texto = texto;
            PerguntaId = perguntaId;
            IsCorreta = isCorreta;
        }
        public int Id {  get; set; }
        public int PerguntaId { get; set; }
        public string Texto { get; set; }
        
        public bool IsCorreta { get; set; }
    }
}
