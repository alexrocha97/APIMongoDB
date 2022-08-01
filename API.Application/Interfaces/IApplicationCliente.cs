using API.Application.Dtos;

namespace API.Application.Interfaces
{
    public interface IApplicationCliente
    {
        void Add(ClienteDto obj);

        ClienteDto GetById(int id);

        IEnumerable<ClienteDto> GetAll();

        void Update(ClienteDto obj);

        void Remove(ClienteDto obj);

        void Dispose();
    }
}
