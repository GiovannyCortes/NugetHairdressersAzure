namespace NugetHairdressersAzure.Models {
    public enum AdminRole :byte { Propietario = 1, Gerente = 2, Supervisor = 3, Empleado = 4 }
    public class Admin {

        public int HairdresserId { get; set; }
        public int UserId { get; set; }
        public AdminRole Role { get; set; }

    }
}
