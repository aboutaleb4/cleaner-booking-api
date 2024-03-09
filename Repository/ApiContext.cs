namespace Repository;

using Domain;
using Microsoft.EntityFrameworkCore;

public class ApiContext : DbContext
{
    public ApiContext(DbSet<Cleaner> cleaners)
    {
        Cleaners = cleaners;
    }

    protected override void OnConfiguring
        (DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase(databaseName: "CleanerDb");
    }
    public DbSet<Cleaner> Cleaners { get; set; }
}