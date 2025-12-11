using Microsoft.AspNetCore.Mvc;
namespace ClinifyBackend.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DoctoresController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Doctor> Get()
        {
            return new List<Doctor>
            {
                new Doctor { Id = 1, Nombre = "Dr. López", Especialidad = "Cardiología" },
                new Doctor { Id = 2, Nombre = "Dra. Ruiz", Especialidad = "Pediatría" }
            };
        }
    }
}
