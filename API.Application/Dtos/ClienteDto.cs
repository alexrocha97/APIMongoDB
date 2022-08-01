namespace API.Application.Dtos
{
    public class ClienteDto
    {
        public ClienteDto(int? id, string nome, string sobrenome, string email)
        {
            Id = id;
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.email = email;
        }

        public int? Id {get; set;}
        public string nome {get; set;}
        public string sobrenome {get; set;}
        public string email {get; set;}
    }
}
