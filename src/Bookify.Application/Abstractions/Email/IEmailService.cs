using Bookify.Domain.Users;

namespace Bookify.Application;

public interface IEmailService
{
    Task SendAsync(Email recipient, string subject, string body);
}
