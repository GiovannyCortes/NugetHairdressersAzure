namespace CutAndGo.Models {
    public class AppointmentUpdates {
        public int AppointmentId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public StatusAppointment Status { get; set; }
    }
}
