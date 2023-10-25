using Microsoft.EntityFrameworkCore;

namespace WebModuleTry2.Models;

public class EFDataContext : DbContext
{
    public EFDataContext(DbContextOptions<EFDataContext> options) : base(options)
    {

    }

    public DbSet<Book> Books { get; set; }

}