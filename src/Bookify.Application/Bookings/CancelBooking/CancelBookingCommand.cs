using Bookify.Application.Abstractions.Messaging;

namespace Bookify.Application.Bookings.CancelBooking;

public record CancelBookingCommand(Guid BookingId) : ICommand;