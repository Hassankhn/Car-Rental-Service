namespace Spareparts.Models
{
    public class UserDTO
    {
        public required string Name { get; set; }
        public required string Password { get; set; }
        public required string Email { get; set; }
        public required string UserCNIC { get; set; }
        public required string Address { get; set; }
    }
}
