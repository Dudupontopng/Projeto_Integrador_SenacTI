using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Integrador.Banco.Configuracao
{
    internal class ConexaoBanco
    {
        public static IDbConnection CriarConexao()
        {
            return new NpgsqlConnection("Server=localhost;" +
                "Port=5432;" +
                "Database=postgres;" +
                "User Id=postgres;" +
                "Password=admin;" +
                "Trust Server Certificate=true;");
        }
    }
}
