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
            // ADD a Book

            // var book = new Book();
            // book.Title = "Need to change";
            // _repository.AddBook(book);

            //==========================

            // DELETE a Book

            // var book2 = new Book();
            // book2.Id = 3;
            //
            // _repository.DeleteBook(book2);

            //==========================

            //CHANGE a Title


            var book3 = new Book();
            book3.Id = 6;
            book3.Title = "Changed Title";
            _repository.UpdateBook(book3);


            //Retun a Books that in DB
            return View(_repository.GetBooks());
        }
    }
}
