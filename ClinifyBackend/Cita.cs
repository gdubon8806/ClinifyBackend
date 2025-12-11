namespace ClinifyBackend.API
{
    public class Cita
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int DoctorId { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
    }
}
