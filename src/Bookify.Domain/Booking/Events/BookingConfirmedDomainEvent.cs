using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Booking.Events;

public record BookingConfirmedDomainEvent(Guid BookingId) : IDomainEvent;
