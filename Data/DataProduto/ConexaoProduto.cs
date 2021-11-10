using System.Data.SqlClient;
namespace PraticandoProjeto.Data.DataProduto
{
    public class ConexaoProduto
    {
        public static SqlConnection ObterConexao()
        {
            string conexao = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=PraticandoProjeto;Data Source=DESKTOP-U3HLT47\\SQLEXPRESS";

            SqlConnection sqlConnection = new SqlConnection(conexao);

            return sqlConnection;
        }
    }
}