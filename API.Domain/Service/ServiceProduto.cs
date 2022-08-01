using API.Domain.Interfaces.Repositorys;
using API.Domain.Interfaces.Services;
using API.Domain.Models;

namespace API.Domain.Service
{
    public class ServiceProduto : ServiceBase<Produto>, IServiceProduto
    {
        public readonly IRepositoryProduto _repositoryProduto;
        public ServiceProduto(IRepositoryProduto repositoryProduto) : base(repositoryProduto)
        {
            _repositoryProduto = repositoryProduto;
        }
    }
}
