using ClinifyBackend.Application.DTOs;
using ClinifyBackend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinifyBackend.Application.Mappers
{
    public static class DoctorMapper
    {
        public static DoctorDto ToDto(Doctor doctor)
        {
            return new DoctorDto
            {
                Id = doctor.Id,
                Nombre = doctor.Nombre,
                Especialidad = doctor.Especialidad
            };
        }
    }
}
