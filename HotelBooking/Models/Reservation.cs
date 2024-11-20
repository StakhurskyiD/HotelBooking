using System.Text.Json.Serialization;

namespace HotelBooking.Models;

public record Reservation
{
    [JsonPropertyName("reservation_id")]
    public Guid ReservationId { get; init; }

    [JsonPropertyName("guest_name")]
    public string GuestName { get; init; } = string.Empty;

    [JsonPropertyName("check_in_date")]
    public DateTime CheckInDate { get; init; }

    [JsonPropertyName("check_out_date")]
    public DateTime CheckOutDate { get; init; }

    [JsonPropertyName("special_requests")]
    public string? SpecialRequests { get; init; }
}