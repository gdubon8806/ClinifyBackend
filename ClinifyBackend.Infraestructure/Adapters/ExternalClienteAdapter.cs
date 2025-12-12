using ClinifyBackend.Application.Interfaces;
using ClinifyBackend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinifyBackend.Infrastructure.Adapters
{
    public class ExternalClienteAdapter : IClienteRepository
    {
        public IEnumerable<Cliente> GetAll()
        {
            // Simula consumir otra fuente, como una API externa
            return new List<Cliente>
            {
                new Cliente { Id = 101, Nombre = "Cliente Externo 1", Correo = "ext1@mail.com", Telefono = "555-9999" },
                new Cliente { Id = 102, Nombre = "Cliente Externo 2", Correo = "ext2@mail.com", Telefono = "555-8888" }
            };
        }
    }
}
