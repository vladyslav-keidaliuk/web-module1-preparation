using Microsoft.AspNetCore.Mvc;
using WebModuleTry2.Models;

namespace WebModuleTry2.Controllers
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
            // Add a Book

            // var book = new Book();
            // book.Title = "Test2";
            // _repository.AddBook(book);

            //==========================

            // Delete a Book

            // var book2 = new Book();
            // book2.Id = 3;
            //
            // _repository.DeleteBook(book2);

            //==========================

            //Retun a Books that in DB
            return View(_repository.GetBooks());
        }
    }
}
