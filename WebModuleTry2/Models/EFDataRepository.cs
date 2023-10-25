namespace WebModuleTry2.Models;

public class EFDataRepository : IDataRepository
{
    private EFDataContext dbContext;

    public EFDataRepository(EFDataContext dataContext)
    {
        dbContext = dataContext;
    }

    // If you want to get book
    public IEnumerable<Book> GetBooks()
    {
        return dbContext.Books;
    }

    // If you want to add book
    public void AddBook(Book book)
    {
        dbContext.Books.Add(book);
        dbContext.SaveChanges();
    }

    // If you want to delete book
    public void DeleteBook(Book book)
    {
        dbContext.Books.Remove(book);
        dbContext.SaveChanges();
    }

    
}