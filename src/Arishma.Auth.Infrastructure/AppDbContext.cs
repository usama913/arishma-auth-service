using Microsoft.EntityFrameworkCore;
using Arishma.Auth.Domain;
namespace Arishma.Auth.Infrastructure;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<User> Users => Set<User>();
    protected override void OnModelCreating(ModelBuilder b)
    {
        b.Entity<User>().ToTable("users");
        base.OnModelCreating(b);
    }
}
