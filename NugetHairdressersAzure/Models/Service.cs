namespace NugetHairdressersAzure.Models {
    public class Service {

        public int ServiceId { get; set; }
        public int HairdresserId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public byte TiempoAprox { get; set; }

    }
}
