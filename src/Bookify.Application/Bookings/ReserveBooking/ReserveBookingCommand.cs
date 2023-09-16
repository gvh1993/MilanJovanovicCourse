namespace Bookify.Application;

public record ReserveBookingCommand
(
    Guid ApartmentId,
    Guid UserId,
    DateOnly StartDate,
    DateOnly EndDate
) : ICommand<Guid>;