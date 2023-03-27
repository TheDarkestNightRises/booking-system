using BookingSystem.Application.RepositoryContracts;
using BookingSystem.Data.Context;
using Microsoft.EntityFrameworkCore;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Data.Repositories;

public class RoomRepository : IRoomRepository
{
    private DataContext _context;

    public RoomRepository(DataContext dataContext)
    {
        _context = dataContext;
    }

    public async Task<List<Room>> GetAllRoomsAsync()
    {
        return await _context.Rooms.ToListAsync();
    }

    public async Task<Room?> GetRoomByIdAsync(int id)
    {
        return await _context.Rooms.FirstOrDefaultAsync(r => r.Id == id);
    }
}
