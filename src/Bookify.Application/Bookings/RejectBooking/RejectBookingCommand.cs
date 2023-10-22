using Bookify.Application.Abstractions.Messaging;

namespace Bookify.Application.Bookings.RejectBooking;

public sealed record RejectBookingCommand(Guid BookingId) : ICommand;