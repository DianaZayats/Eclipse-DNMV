using Microsoft.AspNetCore.Mvc;
using RegistrationUserVova.Data;
using RegistrationUserVova.Models;
using RegistrationUserVova.ViewModels;

namespace RegistrationUserVova.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public HomeController(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("Register")]
        public IActionResult RegisterUser([FromBody] User user)
        {
            var existingUser = _dbContext.Users.FirstOrDefault(u => u.Login == user.Login);
            if (existingUser != null)
            {
                return BadRequest("User with this login already exists");
            }

            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();

            return Ok("User registered successfully");
        }

        [HttpPost("Login")]
        public IActionResult LoginUser([FromBody] LoginViewModel loginData)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.Login == loginData.Username && u.Password == loginData.Password);
            if (user == null)
            {
                return BadRequest("Invalid login credentials");
            }

            return Ok("User logged in successfully");
        }
           

       [HttpGet("EditProfile/{userId}")]
        public IActionResult EditProfile(string userId)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.UsingId == userId);

            if (user == null)
            {
               return NotFound("User not found");
            }

                return View("EditProfile", user);
        }

        [HttpPost("UpdateProfile")]
        public IActionResult UpdateProfile([FromBody] User updatedUser)
        {
           var user = _dbContext.Users.FirstOrDefault(u => u.UsingId == updatedUser.UsingId);

           if (user == null)
           {
             return NotFound("User not found");
           }
           user.FirstName = updatedUser.FirstName;
           user.LastName = updatedUser.LastName;
           user.Email = updatedUser.Email;
           user.PhoneNumber = updatedUser.PhoneNumber;

           _dbContext.SaveChanges();

           return Ok("Profile updated successfully");
        }

       [HttpPost("ChangePassword")]
        public IActionResult ChangePassword([FromBody] ChangeAccountViewModel changePassword)
        {
          var user = _dbContext.Users.FirstOrDefault(u => u.UsingId == changePassword.UsingId);

          if (user == null)
          {
             return NotFound("User not found");
          }

                
          user.Password = changePassword.NewPassword; 

          _dbContext.SaveChanges();

          return Ok("Password changed successfully");
        }
    }

}
