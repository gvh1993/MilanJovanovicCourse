using Bookify.Application.Abstractions.Messaging;

namespace Bookify.Application.Bookings.ConfirmBooking;

public sealed record ConfirmBookingCommand(Guid BookingId) : ICommand;