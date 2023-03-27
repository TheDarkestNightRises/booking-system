using Shared.Models;

namespace BookingSystem.Application.Extensions;

public static class ReservationValidator
{
    public static bool ValidateReservationTimeRange(IEnumerable<Reservation> existingReservations, DateTime startDate, DateTime endDate)
    {
        foreach (var reservation in existingReservations)
        {
            if (endDate >= reservation.DateFrom && startDate <= reservation.DateTo)
            {
                return false;
            }
        }
        
        return true;
    }
}
