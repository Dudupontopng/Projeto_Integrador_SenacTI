using Dapper;
using Projeto_Integrador.Banco.Configuracao;
using Projeto_Integrador.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

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
", new {Id = idUsuario, Nivel = nivel, PontuacaoTotal = pontuacaoTotal, AcertosTotais = acertosTotais, PerguntasRespondidas = perguntasRespondidas, MaiorSequenciaAcertos = maiorSequenciaAcertos, AcertosConsecutivosAtuais = acertosConsecutivosAtuais, UltimoAcesso = ultimoAcesso });
        }
        
    }
}
