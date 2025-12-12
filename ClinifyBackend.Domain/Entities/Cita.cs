using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinifyBackend.Domain.Entities
{
    public class Cita
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int DoctorId { get; set; }
        public string Fecha { get; set; }  // "2025-12-12"
        public string Hora { get; set; }   // "10:00"
    }
}
