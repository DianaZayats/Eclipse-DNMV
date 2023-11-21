using RegistrationUserVova.Models;

namespace RegistrationUserVova.ViewModels
{
    public class DeleteAccountViewModel
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public DeleteAccountViewModel(User users)
        {
            Username = users.FirstName;
            Password = users.Password;
        }
    }
}
