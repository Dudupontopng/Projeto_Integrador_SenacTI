using Projeto_Integrador.Banco.Configuracao;
using System;
using Dapper;
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
    }
}
