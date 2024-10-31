namespace Spareparts.Models
{
    public class User
    {
        public int UserId { get; set; }
        public required string Name { get; set; }
        public required string Password { get; set; }
        public required string Email { get; set; }
        public required string UserCNIC { get; set; }
        public required string Address { get; set; }
        public required DateTime CreatedOn { get; set; } = DateTime.Now;

    }
}
