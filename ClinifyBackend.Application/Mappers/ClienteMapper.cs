using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinifyBackend.Application.DTOs;
using ClinifyBackend.Domain.Entities;

namespace ClinifyBackend.Application.Mappers
{
    public static class ClienteMapper
    {
        public static ClienteDto ToDto(Cliente cliente)
        {
            return new ClienteDto
            {
                Id = cliente.Id,
                Nombre = cliente.Nombre,
                Correo = cliente.Correo,
                Telefono = cliente.Telefono
            };
        }
    }
}
