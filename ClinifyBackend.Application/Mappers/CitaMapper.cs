using ClinifyBackend.Application.DTOs;
using ClinifyBackend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinifyBackend.Application.Mappers
{
    public static class CitaMapper
    {
        public static CitaDto ToDto(Cita cita)
        {
            return new CitaDto
            {
                Id = cita.Id,
                ClienteId = cita.ClienteId,
                DoctorId = cita.DoctorId,
                Fecha = cita.Fecha,
                Hora = cita.Hora
            };
        }
    }
}
