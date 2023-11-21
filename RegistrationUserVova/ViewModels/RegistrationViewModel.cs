using RegistrationUserVova.Models;

namespace RegistrationUserVova.ViewModels
{
    public class RegistrationViewModel
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public RegistrationViewModel(User users)
        {
            Username = users.FirstName;
            Email = users.Email;
            Password = users.Password;
        }
    }
}
