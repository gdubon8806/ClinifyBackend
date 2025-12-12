using ClinifyBackend.Application.Interfaces;
using ClinifyBackend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinifyBackend.Infrastructure.Repositories
{
    public class CitaRepository : ICitaRepository
    {
        public IEnumerable<Cita> GetAll()
        {
            return new List<Cita>
            {
                new Cita { Id = 1, ClienteId = 1, DoctorId = 2, Fecha = "2025-12-12", Hora = "10:00" },
                new Cita { Id = 2, ClienteId = 2, DoctorId = 1, Fecha = "2025-12-13", Hora = "11:30" }
            };
        }
    }
}
