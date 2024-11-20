using Microsoft.AspNetCore.Mvc;

namespace HotelBooking.Controllers;

[ApiController]
[Route("[controller]")]
public class BookingController : ControllerBase
{
    public BookingController()
    {
    }
    
    [HttpGet("available-dates")]
    public IActionResult GetAvailableDates()
    {
        DateTime minDate = DateTime.UtcNow.Date;
        DateTime maxDate = minDate.AddDays(330);

        return Ok(new
        {
            MinDate = minDate.ToString("yyyy-MM-dd"),
            MaxDate = maxDate.ToString("yyyy-MM-dd")
        });
    }

}