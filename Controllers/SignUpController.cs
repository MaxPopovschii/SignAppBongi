using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SignAppBongi.Models;
using SignAppBongi.Models.Context;

namespace SignAppBongi.Controllers
{
    public class SignUpController(SqlContext context) : Controller
    {
        private readonly SqlContext _context = context;

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        // POST: SignUpController/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(UserModel user)
        {
            var existingUser = _context.Users.FirstOrDefault(u => u.Email == user.Email);


            if (existingUser != null) {
                ViewBag.UserExists = true;
                return View("BadRequest", user);
            }

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return RedirectToAction("Success");

        }

        public IActionResult Success()

        {

            return View();

        }

        public IActionResult Error()
        {
            return View();
        }


        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult List() {
            var users = _context.Users.ToList();
            return View(users);
        }
    }
}
