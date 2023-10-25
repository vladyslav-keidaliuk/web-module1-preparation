using LastTestProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace LastTestProject.Controllers
{
    public class HomeController : Controller
    {
        IDataRepository _repository;

        public HomeController(IDataRepository repository)
        {
            _repository = repository;
        }


        public IActionResult Index()
        {
            // Car car1 = new Car();
            // car1.Brand = "Mercedes";
            // car1.Engine = "2.0";
            //
            // _repository.AddCar(car1);


            // Car car2 = new Car();
            // car2.Id = 1;
            // car2.Brand = "Volkswagen";
            // car2.Engine = "1.6";
            //
            // _repository.UpdateCar(car2);

            // Car car3 = new Car();
            // car3.Id = 4;
            // _repository.DeleteCar(car3);

            return View(_repository.GetCars());
        }
    }
}
