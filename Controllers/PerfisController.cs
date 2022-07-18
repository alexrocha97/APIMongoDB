// using System.Linq;
// using Microsoft.AspNetCore.Mvc;
// using MongoDB.Driver;
// using MongoDBAPIC.Models;

// namespace MongoDBAPIC.Controllers
// {
//     [ApiController]
//     [Route("[controller]")]
//     public class PerfisController : ControllerBase
//     {
//         private readonly IConfiguration _configuration;
//         public PerfisController(IConfiguration configuration)
//         {
//             _configuration = configuration;
//         }

//         [HttpGet]
//         public async Task<ActionResult> ListarMatriculaPublicoAlvo(AccessDetailsParams AcessParams)
//         {
//             MongoClient dbClient = new MongoClient(_configuration.GetConnectionString("ConnectionMongo"));
//             var perfis = dbClient.GetDatabase("Perfis").GetCollection<Perfil>("Perfis").AsQueryable().ToList();

//             var perfil = perfis;
//         }

//         [HttpGet]
//         public ActionResult ListarPerfis(AccessDetailsParams obj)
//         {
//             MongoClient dbClient = new MongoClient(_configuration.GetConnectionString("ConnectionMongo"));

//             var filter = Builders<Perfil>.Filter.ElemMatch(x => x.GruposAcionadores, a => a.Acionadores.Any(p => p.Anos.Equals(obj.Ano) && p.StatusOvPossiveis.Equals(obj.StatusPagamento) && p.Produtos.Equals(obj.ProductGroupId)));
            
//             var perfis = dbClient.GetDatabase("testedb").GetCollection<Perfil>("Perfis").Find(filter);

//             var permissaoAluno = dbClient.GetDatabase("testedb").GetCollection<Permissao>("PermissaoAluno").AsQueryable();

//             var alunos = permissaoAluno.ToList();
//             var lstperfis = perfis.ToList(); 

//             return Ok(lstperfis);
//         }
//     }
// }
