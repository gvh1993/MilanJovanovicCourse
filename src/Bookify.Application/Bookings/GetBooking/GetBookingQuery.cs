namespace Bookify.Application;

public sealed record class GetBookingQuery(Guid BookingId) : IQuery<BookingResponse>;
