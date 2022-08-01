namespace API.Domain.Models
{
    public class Produto : Base
    {
        public Produto(string nome, decimal valor, bool disponivel, int clienteId, Cliente cliente)
        {
            this.nome = nome;
            this.valor = valor;
            this.disponivel = disponivel;
            ClienteId = clienteId;
            Cliente = cliente;
        }

        public string nome {get; set;}
        public decimal valor {get; set;}
        public bool disponivel {get; set;}
        public int ClienteId {get; set;}
        public virtual Cliente Cliente {get; set;}
    }
}
