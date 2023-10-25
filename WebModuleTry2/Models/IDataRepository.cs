namespace WebModuleTry2.Models;

public interface IDataRepository
{
  public  IEnumerable<Book> GetBooks();

    // If you want to add books
  void AddBook(Book book);

  void DeleteBook(Book book);

  void UpdateBook(Book book);
}