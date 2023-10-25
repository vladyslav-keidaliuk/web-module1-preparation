namespace WebModuleTry2.Models;

public class EFDataRepository : IDataRepository
{
    private EFDataContext dbContext;

    public EFDataRepository(EFDataContext dataContext)
    {
        dbContext = dataContext;
    }

    public IEnumerable<Book> GetBooks()
    {
        return dbContext.Books;
    }

    public void AddBook(Book book)
    {
        dbContext.Books.Add(book);
        dbContext.SaveChanges();
    }
}