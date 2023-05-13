namespace CutAndGo.Models {
    public class AppointmentRegister {
        public int UserId { get; set; }
        public int HairdresserId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public StatusAppointment Status { get; set; }
    }
}