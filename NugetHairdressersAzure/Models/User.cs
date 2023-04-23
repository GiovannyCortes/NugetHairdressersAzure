namespace NugetHairdressersAzure.Models {
    public class User {

        public int UserId { get; set; }
        public byte[] Password { get; set; }
        public string PasswordRead { get; set; }
        public string Salt { get; set; }
        public string Name { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string? TempToken { get; set; }

    }
}
