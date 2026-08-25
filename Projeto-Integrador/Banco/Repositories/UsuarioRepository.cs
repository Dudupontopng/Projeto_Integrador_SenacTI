using Dapper;
using Projeto_Integrador.Banco.Configuracao;
using Projeto_Integrador.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Projeto_Integrador.Banco.Repositories;

namespace Projeto_Integrador.Banco.Repositories
{
    public class UsuarioRepository
    {
        private static ConexaoBanco ConexaoBanco = new ConexaoBanco();

        public static async Task Adicionar(Usuario usuario)
        {
            await ConexaoBanco.CriarConexao().QueryAsync(
            @"Insert Into quiz.usuario(Nome, Nickname, Senha, DataDeNascimento)
                Values(@Nome, @Nickname, @Senha, @DataNascimento);
            ",
            usuario

            );
        }
        public static async Task<Usuario?> ObterPorUsuario(string nickname)
        {
            var usuario = await ConexaoBanco.CriarConexao().QueryFirstOrDefaultAsync<Usuario>(@"
            Select 
            Id,
            Nickname,
            Senha
            FROM quiz.usuario
            Where Nickname = @Nickname;
            ", new { Nickname = nickname });
            return usuario;


        }
        public static async Task<Usuario?> ObterPorId(int? id)
        {
            if (id == null) return null;

            var usuario = await ConexaoBanco.CriarConexao().QueryFirstOrDefaultAsync<Usuario>(@"
            Select 
            Id,
            Nickname,
            Senha,
            DataDeNascimento,
            Nivel,
            PontuacaoTotal,
            AcertosTotais,
            PerguntasRespondidas,
            MaiorSequenciaAcertos,
            AcertosConsecutivosAtuais,
            UltimoAcesso
            FROM quiz.usuario
            Where Id = @Id;
            ", new { Id = id });

            if (usuario != null)
            {
                var temaObj = await ObterTemaDominante(usuario.Id);
                usuario.TemaDominante = temaObj != null ? temaObj.Tema : "Nenhum";
            }

            return usuario;
        }
        public static async Task AtualizarUsuario(int idUsuario, string nivel, int pontuacaoTotal, int acertosTotais, int perguntasRespondidas, int maiorSequenciaAcertos, int acertosConsecutivosAtuais, DateTime ultimoAcesso)
        {
            var usuario = await ConexaoBanco.CriarConexao().QueryAsync(
                @"
                Update quiz.usuario 
                set Nivel = @Nivel,
                PontuacaoTotal = @PontuacaoTotal,
                AcertosTotais = @AcertosTotais,
                PerguntasRespondidas = @PerguntasRespondidas,
                MaiorSequenciaAcertos = @MaiorSequenciaAcertos,
                AcertosConsecutivosAtuais = @AcertosConsecutivosAtuais,
                UltimoAcesso = @UltimoAcesso
                Where Id = @Id;
", new { Id = idUsuario, Nivel = nivel, PontuacaoTotal = pontuacaoTotal, AcertosTotais = acertosTotais, PerguntasRespondidas = perguntasRespondidas, MaiorSequenciaAcertos = maiorSequenciaAcertos, AcertosConsecutivosAtuais = acertosConsecutivosAtuais, UltimoAcesso = ultimoAcesso });
        }
        public static async Task<TemaDominante?> ObterTemaDominante(int idUsuario)
        {
            using var conexao = ConexaoBanco.CriarConexao();

            var sql = @"
        SELECT 
            TemaPergunta AS Tema, 
            CAST (COUNT(*) AS INT) AS Quantidade
        FROM quiz.historico_partida
        WHERE UsuarioId = @UsuarioId AND Acertou = true
        GROUP BY TemaPergunta
        ORDER BY Quantidade DESC
        LIMIT 1;
    ";

            return await conexao.QueryFirstOrDefaultAsync<TemaDominante>(sql, new { UsuarioId = idUsuario });
        }

        public static async Task<IEnumerable<Usuario>> ObterTodos()
        {
            using var conexao = ConexaoBanco.CriarConexao();

            var sql = @"
            SELECT 
                Id,
                Nome,
                Nickname,
                DataDeNascimento AS DataNascimento,
                Nivel,
                PontuacaoTotal,
                AcertosTotais,
                PerguntasRespondidas,
                MaiorSequenciaAcertos,
                AcertosConsecutivosAtuais,
                UltimoAcesso
            FROM quiz.usuario;";

            return await conexao.QueryAsync<Usuario>(sql);
        }

        public static async Task<IEnumerable<Usuario>> ObterRanking()
        {
            var usuarios = await ObterTodos();

            var listaOrdenada = usuarios.OrderByDescending(u => u.PontuacaoTotal)
                                        .ThenByDescending(u => u.AcertosTotais)
                                        .ToList();

            int posicao = 1;
            foreach (var usuario in listaOrdenada)
            {
                usuario.Posicao = posicao++;

                var temaObj = await ObterTemaDominante(usuario.Id);
                usuario.TemaDominante = temaObj != null ? temaObj.Tema : "Nenhum";
            }

            return listaOrdenada;
        }

        public static async Task AlterarSenha(int idUsuario, string novaSenhaCriptografada)
        {
            using var conexao = ConexaoBanco.CriarConexao();

            string sql = @"
                UPDATE quiz.usuario 
                SET Senha = @Senha 
                WHERE Id = @Id;";

            await conexao.ExecuteAsync(sql, new { Senha = novaSenhaCriptografada, Id = idUsuario });
        }

        public static async Task<int> ObterAcertosPorTema(int idUsuario, string tema)
        {
            var sql = @"
            SELECT COUNT(*) 
            FROM quiz.historico_partida
            WHERE UsuarioId = @UsuarioId 
              AND Acertou = true 
              AND LOWER(TemaPergunta) ILIKE LOWER(@Tema);";

            return await ConexaoBanco.CriarConexao().ExecuteScalarAsync<int>(sql, new { UsuarioId = idUsuario, Tema = $"%{tema}%" });
        }

        public static async Task AtualizarDiasSeguidosEAcesso(int idUsuario)
        {
            using var conexao = ConexaoBanco.CriarConexao();

            var sqlBusca = "SELECT UltimoAcesso, DiasSeguidos FROM quiz.usuario WHERE Id = @Id;";
            var dados = await conexao.QueryFirstOrDefaultAsync<dynamic>(sqlBusca, new { Id = idUsuario });

            if (dados == null) return;

            DateTime? ultimoAcesso = dados.ultimoacesso;
            int diasSeguidos = dados.diasseguidos ?? 0;
            DateTime hoje = DateTime.Today;

            if (ultimoAcesso.HasValue)
            {
                DateTime dataUltimoAcesso = ultimoAcesso.Value.Date;
                int diferencaDias = (hoje - dataUltimoAcesso).Days;

                if (diferencaDias == 1)
                {

                    diasSeguidos++;
                }
                else if (diferencaDias > 1)
                {
                    diasSeguidos = 1;
                }
                
            }
            else
            {
                diasSeguidos = 1;
            }

            var sqlUpdate = @"
        UPDATE quiz.usuario 
        SET UltimoAcesso = @Hoje, 
            DiasSeguidos = @DiasSeguidos 
        WHERE Id = @Id;";

            await conexao.ExecuteAsync(sqlUpdate, new { Hoje = hoje, DiasSeguidos = diasSeguidos, Id = idUsuario });
        }
    }
}
