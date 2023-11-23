using Eclipse;
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

        [HttpGet]
        public IActionResult RegisterUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterUser(User user)
        {
            var existingUser = _dbContext.Users.FirstOrDefault(u => u.Login == user.Login);
            if (existingUser != null)
            {
                return BadRequest("User with this login already exists");
            }

            var passwordHashing = new PasswordHashing();
            passwordHashing.GenerateSalt(); 
        
            string hashedPassword = passwordHashing.HashPassword(user.Password);
            string salt = passwordHashing.salt;

            user.Password = hashedPassword;
            user.Salt = salt;

            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();

            return RedirectToAction(nameof (Index));
        }

        [HttpGet]
        public IActionResult LoginUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginUser(User user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }

            var existingUser = _dbContext.Users.FirstOrDefault(u => u.Login == user.Login);
            if (existingUser == null)
            {
                ModelState.AddModelError("", "Invalid login credentials");
                ViewBag.Message = "Incorrect login or password";
                return View(user);
            }

            var passwordHashing = new PasswordHashing();
            passwordHashing.salt = existingUser.Salt;
            if(existingUser.Password ==  passwordHashing.HashPassword(user.Password))
            {
                return RedirectToAction(nameof(Details), new { userId = existingUser.Id });
            }

            ModelState.AddModelError("", "Invalid password credentials");
            return View(user);

        }

        [HttpGet]
        public IActionResult Details(int userId)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.Id == userId);

            if (user == null)
            {
                return NotFound("User not found");
            }

            return View(user);
        }

        [HttpGet]
        public IActionResult EditProfile(int userId)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.Id == userId);
            if (user == null)
            {
                return NotFound("User not found");
            }

            return View(user); 
        }

        [HttpPost]
        public IActionResult EditProfile(User user)
        {
            var existingUser = _dbContext.Users.FirstOrDefault(u => u.Id == user.Id);
            if (existingUser == null)
            {
                return NotFound("User not found");
            }

            existingUser.FirstName = user.FirstName;
            existingUser.LastName = user.LastName;
            existingUser.Email = user.Email;
            existingUser.PhoneNumber = user.PhoneNumber;
            
            var passwordHashing = new PasswordHashing();
            passwordHashing.salt = existingUser.Salt;
            existingUser.Password = passwordHashing.HashPassword(user.Password);

            _dbContext.SaveChanges();

            return RedirectToAction("Index", "Home"); 
        }


        [HttpPost("UpdateProfile")]
        public IActionResult UpdateProfile(User updatedUser)
        {
           var user = _dbContext.Users.FirstOrDefault(u => u.Id == updatedUser.Id);

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
        public IActionResult ChangePassword(ChangeAccountViewModel changePassword)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.Id == changePassword.Id);

            if (user == null)
            {
                return NotFound("User not found");
            }

            var passwordHashing = new PasswordHashing();
            passwordHashing.GenerateSalt(); 
           
            string hashedPassword = passwordHashing.HashPassword(changePassword.NewPassword);

            user.Password = hashedPassword; 

            _dbContext.SaveChanges();

            return Ok("Password changed successfully");
        }

        [HttpGet]
        public IActionResult DeleteAccount(int userId)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.Id == userId);

            return View(user);
        }

        [HttpPost]
        public IActionResult DeleteAccount(User user) 
        {

            if (user == null)
            {
                return NotFound("User not found");
            }

            _dbContext.Users.Remove(user);
            _dbContext.SaveChanges();


            return RedirectToAction(nameof (RegisterUser));
        }

    }

}
