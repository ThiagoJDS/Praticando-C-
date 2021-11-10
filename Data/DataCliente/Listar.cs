using System.Data.SqlClient;
using System.Text;

namespace PraticandoProjeto.Data.DataCliente
{
    public class Listar
    {
        public static string ObterTodasAsInformacoesClientes(SqlConnection conexao)
        {
            string selectClientes = @"Select * From Cliente";

            SqlCommand comando = new SqlCommand(selectClientes, conexao);
            SqlDataReader leitor = comando.ExecuteReader();

            StringBuilder sb = new StringBuilder();

            while(leitor.Read())
            {
                sb.Append("ID: ").Append(leitor["id"]).Append("\n")
                  .Append("Nome: ").Append(leitor["nome"]).Append("\n")
                  .Append("Cpf: ").Append(leitor["cpf"]).Append("\n")
                  .Append("Celular: ").Append(leitor["celular"]).Append("\n")
                  .Append("Email: ").Append(leitor["email"]).Append("\n").Append("\n");
            }

            return sb.ToString();
        }
    }
}