namespace PraticandoProjeto.Models
{
    public class Compra
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public double valorUnitario { get; set; }
        public int estoque { get; set; }

        public Compra(int id, string descricao, double valorUnitario, int estoque)
        {
            this.id = id;
            this.descricao = descricao;
            this.valorUnitario = valorUnitario;
            this.estoque = estoque;
        }

        public Compra()
        {

        }
    }
}