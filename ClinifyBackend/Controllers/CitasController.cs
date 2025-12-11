using Microsoft.AspNetCore.Mvc;
namespace ClinifyBackend.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CitasController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Cita> Get()
        {
            return new List<Cita>
            {
                new Cita { Id = 1, ClienteId = 1, DoctorId = 2, Fecha = "2025-12-12", Hora = "10:00" },
                new Cita { Id = 2, ClienteId = 2, DoctorId = 1, Fecha = "2025-12-13", Hora = "11:30" }
            };
        }
    }
}
