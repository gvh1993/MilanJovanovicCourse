using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Booking.Events;

public sealed record BookingCancelledDomainEvent(Guid BookingId) : IDomainEvent;
