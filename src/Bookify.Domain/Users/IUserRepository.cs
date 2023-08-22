namespace Bookify.Domain.Users;

public interface IUserRepository
{
    Task<User?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    void Add(User user);
}
