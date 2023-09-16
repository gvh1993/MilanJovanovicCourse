using System.Data;

namespace Bookify.Application;

public interface ISqlConnectionFactory
{
    IDbConnection CreateConnection();
}
