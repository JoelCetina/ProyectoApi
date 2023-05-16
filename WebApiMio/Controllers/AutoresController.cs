using Microsoft.AspNetCore.Mvc;
using WebApiMio.Entidades;

namespace WebApiMio.Controllers
{
    [ApiController]
    [Route("api/autores")]
    public class AutoresController: ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Autor>> Get()
        {
            return new List<Autor>() {
                new Autor() {Id=1, nombre= "felipe" },
                new Autor() {Id=2, nombre= "juan" }
            };
        }
    }
}