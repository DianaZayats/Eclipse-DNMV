namespace RegistrationUserVova.Models
{
    public class DeactivateAccountViewModel
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public DeactivateAccountViewModel(User users)
        {
            Username = users.FirstName;

            Password = users.Password;

            Email = users.Email;
        }
    }
}
