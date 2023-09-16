using Bookify.Domain.Bookings;
using Bookify.Domain.Bookings.Events;
using Bookify.Domain.Users;
using MediatR;

namespace Bookify.Application;

internal sealed class BookingReservedDomainHandler : INotificationHandler<BookingReservedDomainEvent>
{
    private readonly IBookingRepository _bookingRepository;
    private readonly IUserRepository _userRepository;
    private readonly IEmailService _emailService;

    public BookingReservedDomainHandler(
        IEmailService emailService,
        IUserRepository userRepository,
        IBookingRepository bookingRepository)
    {
        _emailService = emailService;
        _userRepository = userRepository;
        _bookingRepository = bookingRepository;
    }

    public async Task Handle(BookingReservedDomainEvent notification, CancellationToken cancellationToken)
    {
        var booking = await _bookingRepository.GetByIdAsync(notification.BookingId);
        if (booking is null)
        {
            return;
        }

        var user = await _userRepository.GetByIdAsync(notification.UserId);
        if (user is null)
        {
            return;
        }

        await _emailService.SendAsync(
            user.Email,
            "Booking reserved!",
            "You have 10 minutes to confirm this booking"
        );
    }
}
