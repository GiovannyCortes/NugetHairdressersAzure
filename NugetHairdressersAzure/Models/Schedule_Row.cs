namespace NugetHairdressersAzure.Models {
    public class Schedule_Row {

        public int ScheduleRowId { get; set; }
        public int ScheduleId { get; set; }
        public TimeSpan Start { get; set; }
        public TimeSpan End { get; set; }
        public bool Monday { get; set; }
        public bool Tuesday { get; set; }
        public bool Wednesday { get; set; }
        public bool Thursday { get; set; }
        public bool Friday { get; set; }
        public bool Saturday { get; set; }
        public bool Sunday { get; set; }

    }
}
