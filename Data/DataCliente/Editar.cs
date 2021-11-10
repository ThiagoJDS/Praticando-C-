using System.Data.SqlClient;
using PraticandoProjeto.Models;

namespace PraticandoProjeto.Data.DataCliente
{
    public class Editar
    {
        public static void Atualizar(SqlConnection conexao, Cliente cliente)
        {
            string alterarCliente = @"Update Cliente set nome = @nome, cpf = @cpf, celular = @celular, email = @email Where id = @id";

            SqlCommand comando = new SqlCommand(alterarCliente, conexao);
            comando.Parameters.AddWithValue("@nome", cliente.nome);
            comando.Parameters.AddWithValue("@cpf", cliente.cpf);
            comando.Parameters.AddWithValue("@celular", cliente.celular);
            comando.Parameters.AddWithValue("@email", cliente.email);
            comando.Parameters.AddWithValue("@id", cliente.id);

            comando.ExecuteNonQuery();
        }
    }
}