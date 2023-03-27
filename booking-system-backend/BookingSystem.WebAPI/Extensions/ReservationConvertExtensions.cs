using BookingSystem.Shared.Dtos;
using Shared.Models;

namespace BookingSystem.WebAPI.Extensions;

public static class ReservationConvertExtensions
{
    public static ReservationReadDto ToReservationReadDto(this Reservation reservation)
    {
        return new ReservationReadDto
        {
            Id = reservation.Id,
            DateTo = reservation.DateTo,
            DateFrom = reservation.DateFrom,
            ReservedPeople = reservation.ReservedPeople,
            RoomId = reservation.RoomId
        };
    }

    public static IEnumerable<ReservationReadDto> ToReservationReadDtos(this IEnumerable<Reservation> reservations)
    {
         return reservations.Select(reservation => reservation.ToReservationReadDto());
    }

    public static Reservation ToReservation(this ReservationCreateDto reservationDto)
    {
        return new Reservation
        {
            DateFrom = reservationDto.DateFrom,
            DateTo = reservationDto.DateTo,
            ReservedPeople = reservationDto.ReservedPeople,
            RoomId = reservationDto.RoomId
        };
    }
}
