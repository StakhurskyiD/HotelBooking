namespace HotelBooking.Services.Contracts;

public interface IBookingDateRangeService
{
    (DateTime MinDate, DateTime MaxDate) GetAvailableDateRange();
}