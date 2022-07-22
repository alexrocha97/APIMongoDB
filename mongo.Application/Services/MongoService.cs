using AutoMapper;
using mongo.Application.Interfaces;
using mongo.Application.ViewModels;
using mongo.Domain.Interfaces;

namespace mongo.Application.Services
{
    public class MongoService : IMongoService
    {
        private readonly IPerfilRepository _repPerfil;
        private readonly IMapper _mapper;
        public MongoService(IPerfilRepository repPerfil, IMapper mapper)
        {
            _repPerfil = repPerfil;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PerfilDTO>> ListarPerfis()
        {
            var result = _repPerfil.ListarPerfis();

            return _mapper.Map<IEnumerable<PerfilDTO>>(result);
        }
    }
}
