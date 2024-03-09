using Domain;
using Microsoft.EntityFrameworkCore;

namespace Repository;

public interface ICleanerRepository
{
    List<Cleaner> GetCleaners();
}

public class CleanerRepository : ICleanerRepository
{
    public CleanerRepository()
    {
        using (var context = new ApiContext())
        {
            var cleaners = new List<Cleaner>()
            {
                new("Alice"),
                new("Bob")
            };
            context.Cleaners.AddRange(cleaners);
            context.SaveChanges();
        }
    }

    public List<Cleaner> GetCleaners()
    {
        using (var context = new ApiContext())
        {
            var cleaners = context.Cleaners
                .ToList();
            return cleaners;
        }
    }
}