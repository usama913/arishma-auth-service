namespace Arishma.Auth.Application;
public interface IUserRepository
{
    Task<IReadOnlyList<UserDto>> ListAsync(CancellationToken ct = default);
}
