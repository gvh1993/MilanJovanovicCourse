namespace Bookify.Application;

public sealed record SearchApartmentQuery(DateOnly StartDate, DateOnly EndDate)
    : IQuery<IReadOnlyList<ApartmentResponse>>;
