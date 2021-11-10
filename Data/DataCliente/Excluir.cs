using System.Data.SqlClient;

namespace PraticandoProjeto.Data.DataCliente
{
    public class Excluir
    {
        public static void Remover(SqlConnection conexao, int id)
        {
            string excluirCliente = @"Delete From Cliente Where id = @id";

            SqlCommand comando = new SqlCommand(excluirCliente, conexao);
            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();
        }
    }
}