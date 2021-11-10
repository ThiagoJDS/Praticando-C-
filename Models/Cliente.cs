namespace PraticandoProjeto.Models
{
    public class Cliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
        
        public Cliente(int id, string nome, string cpf, string celular, string email)
        {
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
            this.celular = celular;
            this.email = email;
        }

        public Cliente(string nome, string cpf, string celular, string email)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.celular = celular;
            this.email = email;
        }
        public Cliente()
        {

        }
    }
}