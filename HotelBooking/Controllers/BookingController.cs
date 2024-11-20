using HotelBooking.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace HotelBooking.Controllers;

[ApiController]
[Route("[controller]")]
public class BookingController : ControllerBase
{
    private IBookingDateRangeService _dateRangeService;
    
    public BookingController(IBookingDateRangeService dateRangeService)
    {
        _dateRangeService = dateRangeService;
    }

    [HttpGet("available-dates")]
    public IActionResult GetAvailableDates()
    {
        var (minDate, maxDate) = _dateRangeService.GetAvailableDateRange();
        return Ok(new
        {
            MinDate = minDate,
            MaxDate = maxDate
        });
    }
}