using Microsoft.AspNetCore.Mvc;
using WebModuleTry1.Models;

namespace WebModuleTry1.Controllers
{
    public class HomeController : Controller
    {
        public IDataRepository _repository;

        public HomeController(IDataRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            var user = new User();
            user.Name = "Test";
            user.Email = "mailtesting@gmail.com";
            _repository.Add(user);

            return View();
        }
    }
}
