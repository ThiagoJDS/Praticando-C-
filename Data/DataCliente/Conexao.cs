using System.Data.SqlClient;

namespace PraticandoProjeto.Data.DataCliente
{
    public class Conexao
    {
        public static SqlConnection ObterConexao()
        {
            string conexao = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=PraticandoProjeto;Data Source=DESKTOP-U3HLT47\\SQLEXPRESS";

            SqlConnection sqlConnection = new SqlConnection(conexao);

            return sqlConnection;

            // dotnet add package System.Data.SqlClient
        }
    }
}