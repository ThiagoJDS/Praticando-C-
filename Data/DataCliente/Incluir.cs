using System.Data.SqlClient;
using PraticandoProjeto.Models;

namespace PraticandoProjeto.Data.DataCliente
{
    public class Incluir
    {
        public static void Novo(SqlConnection conexao, Cliente cliente)
        {
            string insertCliente = @"Insert Into Cliente(nome, cpf, celular, email) Values(@nome, @cpf, @celular, @email)";

            SqlCommand comando = new SqlCommand(insertCliente, conexao);
            comando.Parameters.AddWithValue("@nome", cliente.nome);
            comando.Parameters.AddWithValue("@cpf", cliente.cpf);
            comando.Parameters.AddWithValue("@celular", cliente.celular);
            comando.Parameters.AddWithValue("@email", cliente.email);

            comando.ExecuteNonQuery();
        }
    }
}