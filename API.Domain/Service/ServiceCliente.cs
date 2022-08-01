using API.Domain.Interfaces.Repositorys;
using API.Domain.Interfaces.Services;
using API.Domain.Models;

namespace API.Domain.Service
{
    public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
    {
        public readonly IRepositoryCliente _repositoryCliente;
        public ServiceCliente(IRepositoryCliente repositoryCliente) : base(repositoryCliente)
        {
            _repositoryCliente = repositoryCliente;
        }
    }
}
