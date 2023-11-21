using System.ComponentModel.DataAnnotations;

namespace RegistrationUserVova.Models
{
    public class User
    {
        [Key]
        public string UsingId { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Salt { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirthday { get; set; }

        public string Country { get; set; }
    }
}
