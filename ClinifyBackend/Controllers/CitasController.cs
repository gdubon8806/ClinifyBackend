using ClinifyBackend.Application.Services;
using Microsoft.AspNetCore.Mvc;
namespace ClinifyBackend.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CitasController : ControllerBase
    {
        private readonly CitaService _service;

        public CitasController(CitaService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var citas = _service.ObtenerCitas();
            return Ok(citas);
        }
    }
}
