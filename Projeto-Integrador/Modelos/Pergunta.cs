using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Integrador.Modelos
{
    public class Pergunta
    {
        public Pergunta()
        {

        }
        public Pergunta(int id, string enunciado, string tipo, string nivel, string tema, int pontuacao)
        {
            Id = id;
            Enunciado = enunciado;
            Tipo = tipo;
            Nivel = nivel;
            Tema = tema;
            Pontuacao = pontuacao;
        }
        public Pergunta( string enunciado, string tipo, string nivel, string tema, int pontuacao)
        {
           
            Enunciado = enunciado;
            Tipo = tipo;
            Nivel = nivel;
            Tema = tema;
            Pontuacao = pontuacao;
        }
        public int Id { get; set; }
        public string Enunciado { get; set; }
        public string Tipo { get; set; }
        
        public string Nivel { get; set; }
        public string Tema { get; set; }
        public int Pontuacao { get; set; }
    }
}
