using Microsoft.EntityFrameworkCore;

namespace WebModuleTry1.Models;

public class EFDatabaseContext : DbContext
{
    public EFDatabaseContext(DbContextOptions<EFDatabaseContext> options) : base(options)
    {

    }

    public DbSet<User> Users { get; set; }

}