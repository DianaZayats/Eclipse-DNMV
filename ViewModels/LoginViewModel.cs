using RegistrationUserVova.Models;

namespace RegistrationUserVova.ViewModels
{
    public class LoginViewModel
    {
        public string Username { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public LoginViewModel(User users) 
        {
            Username = users.FirstName;
            Login = users.Login;
            Password = users.Password;
        }
    }
}
