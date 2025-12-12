using ClinifyBackend.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace ClinifyBackend.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly ClienteService _service;

        public ClientesController(ClienteService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var clientes = _service.ObtenerClientes();
            return Ok(clientes);
        }
    }
}
