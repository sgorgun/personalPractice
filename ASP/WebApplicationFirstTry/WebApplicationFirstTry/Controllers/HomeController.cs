using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationFirstTry.Models;
using WebApplicationFirstTry.Domain.Entity;
using WebApplicationFirstTry.Domain.ViewModel.EntityViewModels;


namespace WebApplicationFirstTry.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public IActionResult PrintInfo()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        #region Data output #1

        [HttpGet]
        public IActionResult PrintValue()
        {
            int age = 45;
            char ch = '.';
            string firstName = "Sergei";
            var user = new User { FirstName = firstName, Age = age };
            //return View("PrintValue", $"{user.FirstName} is {user.Age} years old{ch}");
            return View(user);
        }

        #endregion

        #region Collections #2

        [HttpGet]
        public IActionResult PrintValuesCollections()
        {
            var numberList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var numbersArray = new string[] { "one", "two", "three" };
            var users = new List<User>()
            {
                new User { FirstName = "Sergei", Age = 45 },
                new User { FirstName = "Eduard", Age = 46 },
                new User { FirstName = "Andrey", Age = 44 },
            };
            return View(users);
        }

        #endregion

        #region Calculate #3

        [HttpGet]
        public IActionResult Calculate(int firstNumber, int secondNumber)
        {
            var result = firstNumber + secondNumber;
            return View(result);
        }

        #endregion

        #region Adding object to DataBase

        //[HttpGet]
        //public IActionResult CreateUser() => View();

        //[HttpPost]
        //public async Task<IActionResult> CreateUser(CreateUserViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        await _userService.AddUser(model);
        //        return RedirectToAction("GetAllUsers", "Account");
        //    }

        //    return View();
        //}

        #endregion
    }
}
