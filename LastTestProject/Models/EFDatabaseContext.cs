using Microsoft.EntityFrameworkCore;

namespace LastTestProject.Models;

public class EFDatabaseContext : DbContext
{
    public EFDatabaseContext(DbContextOptions<EFDatabaseContext> options) : base(options)
    {

    }

    public DbSet<Car> Cars { get; set; }
    
}