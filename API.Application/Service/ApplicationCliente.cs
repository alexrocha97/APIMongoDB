using API.Application.Dtos;
using API.Application.Interfaces;
using API.Domain.Interfaces.Services;
using API.Infra.Interfaces.Mapper;

namespace API.Application.Service
{
    public class ApplicationCliente : IApplicationCliente
    {
        private readonly IServiceCliente _serviceCliente;
        private readonly IMapperCliente _mapperCliente;
        public ApplicationCliente(IServiceCliente serviceCliente, IMapperCliente mapperCliente)
        {
            _serviceCliente = serviceCliente;
            _mapperCliente = mapperCliente;
        }

        public void Add(ClienteDto obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClienteDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public ClienteDto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(ClienteDto obj)
        {
            throw new NotImplementedException();
        }

        public void Update(ClienteDto obj)
        {
            throw new NotImplementedException();
        }
    }
}
