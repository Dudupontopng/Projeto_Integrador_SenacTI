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
    public class HistoricoRepository
    {
        private static ConexaoBanco ConexaoBanco = new ConexaoBanco();

        public static async Task RegistrarResposta(int usuarioId, int perguntaId, string temaPergunta, bool acertou, int pontuacaoGanha)
        {
            using var conexao = ConexaoBanco.CriarConexao();

            var sql = @"
                INSERT INTO quiz.historico_partida 
                (UsuarioId, PerguntaId, TemaPergunta, Acertou, PontuacaoGanha)
                VALUES 
                (@UsuarioId, @PerguntaId, @TemaPergunta, @Acertou, @PontuacaoGanha);
            ";

            await conexao.ExecuteAsync(sql, new
            {
                UsuarioId = usuarioId,
                PerguntaId = perguntaId,
                TemaPergunta = temaPergunta,
                Acertou = acertou,
                PontuacaoGanha = pontuacaoGanha
            });
        }

        public static async Task<List<HistoricoExibicao>> ObterHistoricoUsuario(int idUsuario)
        {
            using var conexao = ConexaoBanco.CriarConexao();

            
            var sql = @"
        SELECT 
            TemaPergunta AS Tema, 
            Acertou, 
            PontuacaoGanha AS Pontos
        FROM quiz.historico_partida
        WHERE UsuarioId = @UsuarioId
        ORDER BY Id DESC
        LIMIT 50;
    ";

            var resultado = await conexao.QueryAsync<HistoricoExibicao>(sql, new { UsuarioId = idUsuario });
            return resultado.ToList();
        }
    }
}
