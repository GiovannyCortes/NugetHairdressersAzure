namespace CutAndGo.Models {
    public class Schedule {

        public int ScheduleId { get; set; }
        public int HairdresserId { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public List<Schedule_Row> ScheduleRows { get; set; }

    }
}
