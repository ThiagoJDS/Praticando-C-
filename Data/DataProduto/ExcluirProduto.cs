using System.Data.SqlClient;

namespace PraticandoProjeto.Data.DataProduto
{
    public class ExcluirProduto
    {
        public static void Remover(SqlConnection conexao, int id)
        {
            string deletarProduto = @"Delete From Compra where id = @id";

            SqlCommand comando = new SqlCommand(deletarProduto, conexao);
            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();
        }
    }
}