namespace API.Application.Dtos
{
    public class ProdutoDto
    {
        public ProdutoDto(int? id, string nome, decimal valor)
        {
            Id = id;
            this.nome = nome;
            this.valor = valor;
        }

        public int? Id {get; set;}
        public string nome {get; set;}
        public decimal valor {get; set;}
    }
}
