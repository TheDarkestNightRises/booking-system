using BookingSystem.Application.Extensions;
using BookingSystem.Application.LogicContracts;
using BookingSystem.Application.RepositoryContracts;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Application.Logic;

public class ReservationLogic : IReservationLogic
{
    private readonly IReservationRepository _reservationRepository;
    private readonly IRoomRepository _roomRepository;

    public ReservationLogic(IReservationRepository reservationRepository,IRoomRepository roomRepository)
    {
        _reservationRepository = reservationRepository;
        _roomRepository = roomRepository;
    }

    public async Task<List<Reservation>> GetAllReservationsAsync()
    {
        return await _reservationRepository.GetAllReservationsAsync();
    }

    public async Task<Reservation> ReserveRoomAsync(Reservation reservation) {

        var room = await _roomRepository.GetRoomByIdAsync(reservation.RoomId);

        if (room == null)
        {
            throw new ArgumentException("Room not found");
        }

        var existingReservations = await _reservationRepository.GetReservationsByRoomIdAsync(reservation.RoomId);

        if (!ReservationValidator.ValidateReservationTimeRange(existingReservations, reservation.DateFrom, reservation.DateTo))
        {
            throw new ArgumentException("Reservation time range overlaps with existing reservations");
        }

        if (room.NumberOfPeople < reservation.ReservedPeople)
        {
            throw new ArgumentException("Room capacity is not sufficient for the number of people in the reservation");
        }

        var createdReservation = await _reservationRepository.CreateReservationAsync(reservation);

        if (createdReservation == null)
        {
            throw new Exception("Failed to create reservation");
        }

        return createdReservation;
    }
}
