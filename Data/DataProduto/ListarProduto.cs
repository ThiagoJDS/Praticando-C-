using System.Data.SqlClient;
using System.Text;

namespace PraticandoProjeto.Data.DataProduto
{
    public class ListarProduto
    {
        public static string ObterTodasAsInformacoesCompras(SqlConnection conexao)
        {
            string selectProduto = @"Select * From Compra";

            SqlCommand comando = new SqlCommand(selectProduto, conexao);
            SqlDataReader leitor = comando.ExecuteReader();

            StringBuilder sb = new StringBuilder();

            while(leitor.Read())
            {
                sb.Append("ID: ").Append(leitor["id"]).Append("\n")
                  .Append("Descrição: ").Append(leitor["descricao"]).Append("\n")
                  .Append("Valor Unitario: ").Append(leitor["valorUnitario"]).Append("\n")
                  .Append("Estoque: ").Append(leitor["estoque"]).Append("\n").Append("\n");  
            }

            return sb.ToString();
        }
    }
}