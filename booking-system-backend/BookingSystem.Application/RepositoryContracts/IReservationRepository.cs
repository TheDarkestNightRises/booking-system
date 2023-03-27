using Shared.Models;

namespace BookingSystem.Application.RepositoryContracts;

public interface IReservationRepository
{
    Task<List<Reservation>> GetAllReservationsAsync();
    Task<List<Reservation>> GetReservationsByRoomIdAsync(int roomId);
    Task<Reservation> CreateReservationAsync(Reservation reservation);
}