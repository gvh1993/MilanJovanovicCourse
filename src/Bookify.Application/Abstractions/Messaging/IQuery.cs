using Bookify.Domain.Abstractions;
using MediatR;

namespace Bookify.Application;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{

}
