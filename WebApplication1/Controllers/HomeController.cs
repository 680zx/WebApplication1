using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ViewResult Start()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Quiz()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Quiz(UserAnswer userAnswer)
        {
            Repository.AddUserAnswer(userAnswer);
            return View("Result", userAnswer);
        }

        [HttpGet]
        public ViewResult ResultTable()
        {
            return View(Repository.UserAnswers.ToList().OrderByDescending(i => i.Points));
        }
    }
}
