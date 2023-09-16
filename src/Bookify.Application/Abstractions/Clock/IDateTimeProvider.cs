namespace Bookify.Application;

public interface IDateTimeProvider
{
    DateTime UtcNow { get; }
}
