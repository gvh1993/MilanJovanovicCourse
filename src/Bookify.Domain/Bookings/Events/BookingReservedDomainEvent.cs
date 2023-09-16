using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Bookings.Events;

public sealed record BookingReservedDomainEvent(Guid BookingId, Guid UserId) : IDomainEvent;
