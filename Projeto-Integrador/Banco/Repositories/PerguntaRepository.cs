using Dapper;
using Projeto_Integrador.Banco.Configuracao;
using Projeto_Integrador.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Integrador.Banco.Repositories
{
    public class PerguntaRepository
    {
        private static ConexaoBanco ConexaoBanco = new ConexaoBanco();
        public static async Task<List<Pergunta>> ObterPerguntasQuiz()
        {
            var perguntas = await ConexaoBanco.CriarConexao().QueryAsync<Pergunta>(@"
            (SELECT Id, Enunciado, Tipo, Nivel, Tema, Pontuacao 
             FROM quiz.pergunta 
             WHERE Nivel = 'Avançado' 
             ORDER BY RANDOM() LIMIT 1)
            UNION ALL
            (SELECT Id, Enunciado, Tipo, Nivel, Tema, Pontuacao 
             FROM quiz.pergunta 
             WHERE Nivel != 'Avançado' 
             ORDER BY RANDOM() LIMIT 9);
            ");
            var random = new Random();
            return perguntas.OrderBy(x => random.Next()).ToList();
        }
        public static async Task Adicionar(Pergunta pergunta)
        {
            await ConexaoBanco.CriarConexao().QueryAsync(
                 @"
                 INSERT INTO quiz.pergunta(Enunciado, Tipo, Nivel, Tema, Pontuacao)
                 VALUES(@Enunciado, @Tipo, @Nivel, @Tema, @Pontuacao);                  
                 ",
                 pergunta
                 );
        }


    }
}
