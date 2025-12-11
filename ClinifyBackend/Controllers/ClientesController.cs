using Microsoft.AspNetCore.Mvc;

namespace ClinifyBackend.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            return new List<Cliente>
            {
                new Cliente { Id = 1, Nombre = "Juan Pérez", Correo = "juan@mail.com", Telefono = "555-1234" },
                new Cliente { Id = 2, Nombre = "Ana Gómez", Correo = "ana@mail.com", Telefono = "555-5678" }
            };
        }
    }
}
