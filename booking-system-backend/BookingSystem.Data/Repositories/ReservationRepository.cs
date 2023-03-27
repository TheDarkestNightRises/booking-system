using BookingSystem.Application.RepositoryContracts;
using BookingSystem.Data.Context;
using Microsoft.EntityFrameworkCore;
using Shared.Models;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Data.Repositories;

public class ReservationRepository : IReservationRepository
{
    private readonly DataContext _context;

    public ReservationRepository(DataContext dataContext)
    {
        _context = dataContext;
    }

    public async Task<Reservation> CreateReservationAsync(Reservation reservation)
    {
        await _context.Reservations.AddAsync(reservation);
        await _context.SaveChangesAsync();
        return reservation;
    }

    public async Task<List<Reservation>> GetAllReservationsAsync()
    {
        return await _context.Reservations.ToListAsync();
    }

    public async Task<List<Reservation>> GetReservationsByRoomIdAsync(int roomId)
    {
        return await _context.Reservations.Where(r => r.RoomId == roomId).ToListAsync();
    }
}
