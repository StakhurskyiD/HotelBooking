using HotelBooking.Services.Contracts;

namespace HotelBooking.Services.Impl;

public class BookingDateRangeService : IBookingDateRangeService
{
    /*
     * It is better to move the logic for getting the value of `maxDaysAhead`
     * to a separate service because this value might change and could
     * depend on specific hotel policies or configurations.
     */
    private const int MaxDaysAhead = 330;
    
    public (DateTime MinDate, DateTime MaxDate) GetAvailableDateRange()
    {
        var minDate = DateTime.UtcNow.Date;
        var maxDate = minDate.AddDays(MaxDaysAhead);

        return (minDate, maxDate);
    }
}