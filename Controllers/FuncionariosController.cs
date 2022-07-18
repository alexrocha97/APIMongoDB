using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using MongoDBAPIC.Models;

namespace MongoDBAPIC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuncionariosController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _env;
        public FuncionariosController(IConfiguration configuration, IWebHostEnvironment env)
        {
            _configuration = configuration;
            _env = env;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            MongoClient dbClient = new MongoClient(_configuration.GetConnectionString("ConnectionMongo"));

            var dblist = dbClient.GetDatabase("testedb").GetCollection<Employee>("Employee").AsQueryable();

            return Ok(dblist);
        }

        [HttpPost]
        public IActionResult Post(Employee funcio)
        {
            MongoClient dbClient = new MongoClient(_configuration.GetConnectionString("ConnectionMongo"));

            int lstDepartamentoId = dbClient.GetDatabase("testedb").GetCollection<Employee>("Employee").AsQueryable().Count();
            funcio.EmployeeId = lstDepartamentoId + 1;

            dbClient.GetDatabase("testedb").GetCollection<Employee>("Employee").InsertOne(funcio);

            return Ok(new { message = "Departamento cadastrado com sucesso!"});
        }

        [HttpPut]
        public IActionResult Put(Employee funcio)
        {
            MongoClient dbClient = new MongoClient(_configuration.GetConnectionString("ConnectionMongo"));

            var filter = Builders<Employee>.Filter.Eq("EmployeeId", funcio.EmployeeId);
            
            var update = Builders<Employee>.Update.Set("Employeenome",funcio.Employeenome)
                                                    .Set("Departamento", funcio.Departamento)
                                                    .Set("DataInicio", funcio.DataInicio)
                                                    .Set("PhotoFileNome",funcio.PhotoFileNome);

            dbClient.GetDatabase("testedb").GetCollection<Employee>("Employee").UpdateOne(filter, update);

            return Ok(new { message = "Departamento atualizado com sucesso!"});
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            MongoClient dbClient = new MongoClient(_configuration.GetConnectionString("ConnectionMongo"));

            var filter = Builders<Employee>.Filter.Eq("EmployeeId", Id);

            dbClient.GetDatabase("testedb").GetCollection<Employee>("Employee").DeleteOne(filter);

            return Ok(new { message = "Departamento deletado com sucesso!"});
        }

        [Route("SaveFile")]
        [HttpPost]
        public IActionResult SaveFile()
        {
            try
            {
                var httpRequest = Request.Form;
                var postedFile = httpRequest.Files[0];
                string filename = postedFile.FileName;
                var physicalPath = _env.ContentRootPath+"/Photos/"+ filename;

                using(var stream = new FileStream(physicalPath, FileMode.Create))
                {
                    postedFile.CopyTo(stream);
                }

                return Ok(filename);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
