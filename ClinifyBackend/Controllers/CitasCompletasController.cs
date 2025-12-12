using ClinifyBackend.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace ClinifyBackend.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CitasCompletasController : ControllerBase
    {
        private readonly CitaFacadeService _facade;

        public CitasCompletasController(CitaFacadeService facade)
        {
            _facade = facade;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var citas = _facade.ObtenerCitasCompletas();
            return Ok(citas);
        }
    }
}
