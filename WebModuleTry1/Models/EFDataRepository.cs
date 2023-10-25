namespace WebModuleTry1.Models;

public class EFDataRepository: IDataRepository
{
    public EFDatabaseContext context;

    public EFDataRepository(EFDatabaseContext context)
    {
        this.context = context;
    }

    public IEnumerable<User> Users { get; set; }

    public void Add(User user)
    {
        context.Users.Add(user);
        context.SaveChanges();
    }

}