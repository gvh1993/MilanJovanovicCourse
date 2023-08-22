using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Booking.Events;

public sealed record BookingReservedDomainEvent(Guid BookingId) : IDomainEvent;
