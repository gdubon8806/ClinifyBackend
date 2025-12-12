using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinifyBackend.Application.DTOs
{
    public class CitaDto
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int DoctorId { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
    }
}
