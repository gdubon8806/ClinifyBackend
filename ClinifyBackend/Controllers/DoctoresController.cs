using ClinifyBackend.Application.Services;
using Microsoft.AspNetCore.Mvc;
namespace ClinifyBackend.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DoctoresController : ControllerBase
    {
        private readonly DoctorService _service;

        public DoctoresController(DoctorService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var doctores = _service.ObtenerDoctores();
            return Ok(doctores);
        }
    }
}
