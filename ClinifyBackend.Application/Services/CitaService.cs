using ClinifyBackend.Application.DTOs;
using ClinifyBackend.Application.Interfaces;
using ClinifyBackend.Application.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinifyBackend.Application.Services
{
    public class CitaService
    {
        private readonly ICitaRepository _repo;

        public CitaService(ICitaRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<CitaDto> ObtenerCitas()
        {
            return _repo.GetAll().Select(c => CitaMapper.ToDto(c));
        }
    }
}
