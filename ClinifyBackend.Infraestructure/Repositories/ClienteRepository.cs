using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinifyBackend.Application.Interfaces;
using ClinifyBackend.Domain.Entities;

namespace ClinifyBackend.Infraestructure.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        public IEnumerable<Cliente> GetAll()
        {
            return new List<Cliente>
            {
                new Cliente { Id = 1, Nombre = "Juan Pérez", Correo = "juan@mail.com", Telefono = "555-1234" },
                new Cliente { Id = 2, Nombre = "Ana Gómez", Correo = "ana@mail.com", Telefono = "555-5678" }
            };
        }
    }   
}
