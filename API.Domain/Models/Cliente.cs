namespace API.Domain.Models
{
    public class Cliente : Base
    {
        public Cliente(string nome, string sobrenome, string email, DateTime dataNascimento, bool ativo)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.email = email;
            this.dataNascimento = dataNascimento;
            this.ativo = ativo;
        }

        public string nome {get; set;}        
        public string sobrenome {get; set;}        
        public string email {get; set;}        
        public DateTime dataNascimento {get; set;}        
        public bool ativo {get; set;}        
    }
}
