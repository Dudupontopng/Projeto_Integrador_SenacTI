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
        public static async Task<int> Adicionar(Pergunta pergunta)
        {
            using var conexao = ConexaoBanco.CriarConexao();

           
            int idGerado = await conexao.ExecuteScalarAsync<int>(
                 @"
         INSERT INTO quiz.pergunta(Enunciado, Tipo, Nivel, Tema, Pontuacao)
         VALUES(@Enunciado, @Tipo, @Nivel, @Tema, @Pontuacao)
         RETURNING Id; 
         ",
                 pergunta
            );

            return idGerado;
        }
        public static async Task<List<Pergunta>> ObterPerguntasInfinitas()
        {
            using var conexao = ConexaoBanco.CriarConexao();
            var sql = "SELECT * FROM quiz.pergunta ORDER BY RANDOM() LIMIT 100;";

            var resultado = await conexao.QueryAsync<Pergunta>(sql);
            return resultado.ToList();
        }
        public static async Task<Pergunta> ObterPerguntaDobroOuNada()
        {
            using var conexao = ConexaoBanco.CriarConexao();

           
            var sql = "SELECT * FROM quiz.pergunta WHERE Nivel = 'avançado' ORDER BY RANDOM() LIMIT 1;";

            var resultado = await conexao.QueryFirstOrDefaultAsync<Pergunta>(sql);

            return resultado;
        }

    }
}
