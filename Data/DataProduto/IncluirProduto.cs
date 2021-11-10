using System.Data.SqlClient;
using PraticandoProjeto.Models;

namespace PraticandoProjeto.Data.DataProduto
{
    
    public class IncluirProduto
    {
        public static void Novo(SqlConnection conexao, Compra compra)
        {
            string insertProduto = @"Insert into Compra(descricao, valorUnitario, estoque) Values(@descricao, @valorUnitario, @estoque)";

            SqlCommand comando = new SqlCommand(insertProduto, conexao);
            comando.Parameters.AddWithValue("@descricao", compra.descricao);
            comando.Parameters.AddWithValue("@valorUnitario", compra.valorUnitario);
            comando.Parameters.AddWithValue("@estoque", compra.estoque);

            comando.ExecuteNonQuery();
        }
    }
}