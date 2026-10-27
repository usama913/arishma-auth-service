using Arishma.Auth.Application;
namespace Arishma.Auth.Infrastructure;
public class EfUserRepository : IUserRepository
{
    private readonly AppDbContext _db;
    public EfUserRepository(AppDbContext db) => _db = db;
    // Phase 0: scaffold returns no rows and never requires a live DB for /health.
    // Phase 1: replace with a real query over _db.Users.
    public Task<IReadOnlyList<UserDto>> ListAsync(CancellationToken ct = default)
        => Task.FromResult<IReadOnlyList<UserDto>>(Array.Empty<UserDto>());
}
