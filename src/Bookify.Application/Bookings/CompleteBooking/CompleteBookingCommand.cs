using Bookify.Application.Abstractions.Messaging;

namespace Bookify.Application.Bookings.CompleteBooking;

public sealed record CompleteBookingCommand(Guid BookingId) : ICommand;
