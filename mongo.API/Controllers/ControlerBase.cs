using Microsoft.AspNetCore.Mvc;

namespace mongo.API.Controllers
{
    public class ControlerBase : ControllerBase
    {
        [NonAction]
        protected BadRequestObjectResult BadRequest(string msg, Exception ex)
        {
            return BadRequest(new {mensagem = msg,
                                    referencia = ex.Message,
                                    stack = ex.StackTrace,
                                    innerExcpetion = ex.InnerException == null ? ex.Message : ex.InnerException.Message});
        }
    }
}
