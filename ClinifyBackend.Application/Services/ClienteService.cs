using ClinifyBackend.Application.DTOs;
using ClinifyBackend.Application.Interfaces;
using ClinifyBackend.Application.Mappers;
using ClinifyBackend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinifyBackend.Application.Services
{
    public class ClienteService
    {
        private readonly IClienteRepository _repo;

        public ClienteService(IClienteRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<ClienteDto> ObtenerClientes()
        {
            var clientes = _repo.GetAll();

            return clientes.Select(c => ClienteMapper.ToDto(c));
        }
    }
}
