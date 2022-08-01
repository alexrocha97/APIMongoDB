using API.Application.Dtos;

namespace API.Application.Interfaces
{
    public interface IApplicationProduto
    {
        void Add(ProdutoDto obj);

        ProdutoDto GetById(int id);

        IEnumerable<ProdutoDto> GetAll();

        void Update(ProdutoDto obj);

        void Remove(ProdutoDto obj);

        void Dispose();
    }
}
