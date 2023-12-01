using Microsoft.EntityFrameworkCore;
using Mosaic.Models.Ftm04100;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Ftm04100> Ftm04100 { get; set; }
}
