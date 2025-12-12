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
    public class DoctorService
    {
        private readonly IDoctorRepository _repo;

        public DoctorService(IDoctorRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<DoctorDto> ObtenerDoctores()
        {
            return _repo.GetAll().Select(d => DoctorMapper.ToDto(d));
        }
    }
}
