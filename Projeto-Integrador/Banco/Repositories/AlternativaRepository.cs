using Dapper;
using Projeto_Integrador.Banco.Configuracao;
using Projeto_Integrador.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Integrador.Banco.Repositories
{
    public class AlternativaRepository
    {
        private static ConexaoBanco ConexaoBanco = new ConexaoBanco();

        public static async Task<List<Alternativa>> ObterAlternativas(int idPergunta)
        {
            var alternativas = await ConexaoBanco.CriarConexao().QueryAsync<Alternativa>(
                @"
                    Select Id,
                    PerguntaId,
                    Texto,
                    IsCorreta
                    from quiz.alternativa a
                    inner join quiz.pergunta p
                    on a.PerguntaId = p.Id
                    Where PerguntaId = @PerguntaId;
", new { PerguntaId = idPergunta }
                );
            return alternativas.ToList();
        }
    }
}
