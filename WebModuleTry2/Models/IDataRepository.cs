namespace WebModuleTry2.Models;

public interface IDataRepository
{
  public  IEnumerable<Book> GetBooks();

  void AddBook(Book book);
}