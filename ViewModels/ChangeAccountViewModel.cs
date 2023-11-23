using RegistrationUserVova.Models;

namespace RegistrationUserVova.ViewModels
{
    public class ChangeAccountViewModel : User
    {
        public string Username { get; set; }

        public string NewPassword { get; set; }

        public string ConfirmPassword { get; set;}

        public string Email { get; set;}

        public ChangeAccountViewModel(User users)
        {
            Username = users.FirstName;
            Email = users.Email;
        }
    }
}
