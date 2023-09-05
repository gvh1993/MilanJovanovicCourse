using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Booking.Events;

public record BookingCompletedDomainEvent(Guid BookingId) : IDomainEvent;
