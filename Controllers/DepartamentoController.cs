using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using MongoDBAPIC.Models;

namespace MongoDBAPIC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepartamentoController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public DepartamentoController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            MongoClient dbClient = new MongoClient(_configuration.GetConnectionString("ConnectionMongo"));

            var listDerpatamento = dbClient.GetDatabase("testedb").GetCollection<Departamento>("Departamento").AsQueryable();

            var listDepartamento = listDerpatamento.ToList();
            return Ok(listDepartamento);
        }

        [HttpPost]
        public IActionResult Post(Departamento depar)
        {
            MongoClient dbClient = new MongoClient(_configuration.GetConnectionString("ConnectionMongo"));

            int lstDepartamentoId = dbClient.GetDatabase("testedb").GetCollection<Departamento>("Departamento").AsQueryable().Count();
            depar.DepartamentoId = lstDepartamentoId + 1;

            dbClient.GetDatabase("testedb").GetCollection<Departamento>("Departamento").InsertOne(depar);

            return Ok(new { message = "Departamento cadastrado com sucesso!"});
        }

        [HttpPut]
        public IActionResult Put(Departamento depar)
        {
            MongoClient dbClient = new MongoClient(_configuration.GetConnectionString("ConnectionMongo"));

            var filter = Builders<Departamento>.Filter.Eq("DepartamentoId", depar.DepartamentoId);
            
            var update = Builders<Departamento>.Update.Set("Departamentoname",depar.Departamentoname);

            dbClient.GetDatabase("testedb").GetCollection<Departamento>("Departamento").UpdateOne(filter, update);

            return Ok(new { message = "Departamento atualizado com sucesso!"});
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            MongoClient dbClient = new MongoClient(_configuration.GetConnectionString("ConnectionMongo"));

            var filter = Builders<Departamento>.Filter.Eq("DepartamentoId", Id);

            dbClient.GetDatabase("testedb").GetCollection<Departamento>("Departamento").DeleteOne(filter);

            return Ok(new { message = "Departamento deletado com sucesso!"});
        }
    }
}
