using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    // GET: /Home/Login
    public IActionResult Login()
    {
        return View(); // returns login.cshtml
    }

    // POST: /Home/Login
    [HttpPost]
    public IActionResult Login(string username, string password)
    {
        // TODO: Add authentication logic here
        if(username == "admin" && password == "123")
        {
            // Login successful
            return RedirectToAction("Index");
        }
        else
        {
            ViewBag.ErrorMessage = "Invalid username or password!";
            return View();
        }
    }

    // GET: /Home/Register
    public IActionResult Register()
    {
        return View(); // returns register.cshtml
    }

    // POST: /Home/Register
    [HttpPost]
    public IActionResult Register(string fullname, string email, string password, string confirmPassword)
    {
        // TODO: Add registration logic here
        if(password == confirmPassword)
        {
            // Registration successful
            return RedirectToAction("Login");
        }
        else
        {
            ViewBag.ErrorMessage = "Passwords do not match!";
            return View();
        }
    }

    public IActionResult Index()
    {
        return View();
    }
}
