using Microsoft.AspNetCore.Mvc;
using StudentFormCsv.Models;

namespace StudentFormCsv.Controllers
{
    

    public class AccountController : Controller
    {
        private readonly AppDbContext _context;

        public AccountController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(Register register)
        {
            if (ModelState.IsValid)
            {
                _context.Add(register);
                await _context.SaveChangesAsync();
                return RedirectToAction("Login");
            }

            return View(register);
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            var student = _context.Registers.FirstOrDefault(s => s.Email == email && s.Password == password);

            if (student != null)
            {
                // Successful login
                // Redirect to the desired page or perform other actions
                return RedirectToAction("Index", "Student");
            }
            else
            {
                // Invalid login
                // Handle the error, e.g., display an error message
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return View();
            }
        }
    }

}
