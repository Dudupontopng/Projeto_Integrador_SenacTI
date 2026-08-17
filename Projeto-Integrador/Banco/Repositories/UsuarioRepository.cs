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
    }
}
