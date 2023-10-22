using Bookify.Application.Abstractions.Messaging;

namespace Bookify.Application.Bookings.CompleteBooking;

public record CompleteBookingCommand(Guid BookingId) : ICommand;