// using Microsoft.AspNetCore.Mvc;
// using MongoDB.Driver;

// namespace MongoDBAPIC.Controllers
// {
//     [ApiController]
//     [Route("[controlelr]")]
//     public class CompanyController : ControllerBase 
//     {
//         private readonly IConfiguration _configuration;
//         public CompanyController(IConfiguration configuration)
//         {
//             _configuration = configuration;
//         }

//         [HttpGet]
//         public ActionResult GetCompany()
//         {
//             MongoClient dbClient = new MongoClient(_configuration.GetConnectionString("ConnectionMongo"));
//         }
//     }
// }
