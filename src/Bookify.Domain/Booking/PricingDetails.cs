using Bookify.Domain.Shared;

namespace Bookify.Domain.Booking;

public record PricingDetails
(
    Money PriceForPeriod,
    Money CleaningFee,
    Money AmenitiesUpCharge,
    Money TotalPrice
);
