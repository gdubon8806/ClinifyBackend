using ClinifyBackend.Application.Interfaces;
using ClinifyBackend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinifyBackend.Infrastructure.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        public IEnumerable<Doctor> GetAll()
        {
            return new List<Doctor>
            {
                new Doctor { Id = 1, Nombre = "Dr. López", Especialidad = "Cardiología" },
                new Doctor { Id = 2, Nombre = "Dra. Ruiz", Especialidad = "Pediatría" }
            };
        }
    }
}
