using Projeto_Integrador.Banco.Configuracao;
using Projeto_Integrador.Modelos;
using System;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Integrador.Banco.Repositories
{
    public static class LojaRepository
    {
        public static async Task<List<ItemLoja>> ObterItensDaLoja()
        {
            var itens = await ConexaoBanco.CriarConexao().QueryAsync<ItemLoja>(
                "SELECT * FROM quiz.item_loja ORDER BY Preco ASC");

            return itens.ToList();
        }

        public static async Task<List<ItemInventario>> ObterInventarioDoUsuario(int usuarioId)
        {
            var inventario = await ConexaoBanco.CriarConexao().QueryAsync<ItemInventario>(@"
                SELECT 
                    i.UsuarioId,
                    i.ItemId,
                    i.Quantidade,
                    l.Nome AS NomeItem,
                    l.TipoEfeito,
                    l.ValorEfeito
                FROM quiz.inventario i
                INNER JOIN quiz.item_loja l ON i.ItemId = l.Id
                WHERE i.UsuarioId = @UsuarioId;
            ", new { UsuarioId = usuarioId });

            return inventario.ToList();
        }

        public static async Task<bool> ComprarItem(int usuarioId, int itemId, int precoItem)
        {
            try
            {
               
                await ConexaoBanco.CriarConexao().ExecuteAsync(@"
                    UPDATE quiz.usuario 
                    SET PontuacaoTotal = PontuacaoTotal - @Preco 
                    WHERE Id = @UsuarioId;

                    INSERT INTO quiz.inventario (UsuarioId, ItemId, Quantidade) 
                    VALUES (@UsuarioId, @ItemId, 1)
                    ON CONFLICT (UsuarioId, ItemId) 
                    DO UPDATE SET Quantidade = inventario.Quantidade + 1;
                ", new { Preco = precoItem, UsuarioId = usuarioId, ItemId = itemId });

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static async Task ConsumirItem(int usuarioId, int itemId)
        {
            await ConexaoBanco.CriarConexao().ExecuteAsync(@"
                UPDATE quiz.inventario 
                SET Quantidade = Quantidade - 1 
                WHERE UsuarioId = @UsuarioId AND ItemId = @ItemId;
                
                DELETE FROM quiz.inventario WHERE Quantidade <= 0;
            ", new { UsuarioId = usuarioId, ItemId = itemId });
        }
    }
}