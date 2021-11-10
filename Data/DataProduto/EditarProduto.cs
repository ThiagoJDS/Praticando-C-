using System.Data.SqlClient;
using PraticandoProjeto.Models;

namespace PraticandoProjeto.Data.DataProduto
{
    public class EditarProduto
    {
        public static void Atualizar(SqlConnection conexao, Compra compra)
        {
            string updateProduto = @"Update Compra set descricao = @descricao, valorUnitario = @valorUnitario, estoque = @estoque Where id = @id";

            SqlCommand comando = new SqlCommand(updateProduto, conexao);
            comando.Parameters.AddWithValue("@descricao", compra.descricao);
            comando.Parameters.AddWithValue("@valorUnitario", compra.valorUnitario);
            comando.Parameters.AddWithValue("@estoque", compra.estoque);
            comando.Parameters.AddWithValue("@id", compra.id);

            comando.ExecuteNonQuery();
        }
    }
}