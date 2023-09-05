using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Booking.Events;

public record BookingRejectedDomainEvent(Guid BookingId) : IDomainEvent;
