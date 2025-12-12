using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinifyBackend.Application.Services
{
    //Facade pattern
    public class CitaFacadeService
    {
        private readonly CitaService _citaService;
        private readonly ClienteService _clienteService;
        private readonly DoctorService _doctorService;

        public CitaFacadeService(CitaService citaService, ClienteService clienteService, DoctorService doctorService)
        {
            _citaService = citaService;
            _clienteService = clienteService;
            _doctorService = doctorService;
        }

        public IEnumerable<object> ObtenerCitasCompletas()
        {
            var citas = _citaService.ObtenerCitas();
            var clientes = _clienteService.ObtenerClientes().ToDictionary(c => c.Id);
            var doctores = _doctorService.ObtenerDoctores().ToDictionary(d => d.Id);

            return citas.Select(c => new
            {
                c.Id,
                Cliente = clientes[c.ClienteId],
                Doctor = doctores[c.DoctorId],
                c.Fecha,
                c.Hora
            });
        }
    }
}
