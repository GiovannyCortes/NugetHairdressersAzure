namespace NugetHairdressersAzure.Models {
    public enum StatusAppointment :int { NoConfirmada = 0, Finalizada = 1, Activa = 2, Cancelada = 3 }
    public class Appointment {

        public int AppointmentId { get; set; }
        public int UserId { get; set; }
        public int HairdresserId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public StatusAppointment Status { get; set; }

    }
}
