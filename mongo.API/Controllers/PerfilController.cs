using Microsoft.AspNetCore.Mvc;
using mongo.Application.Interfaces;
using mongo.Application.ViewModels;

namespace mongo.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PerfilController : ControlerBase
    {
        [HttpGet("ListaDePerfis")]
        public ActionResult<IEnumerable<PerfilDTO>> GetPerfis(
            [FromServices]IMongoService service)
        {
            try
            {
                var result = service.ListarPerfis();
                return Ok(result);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
