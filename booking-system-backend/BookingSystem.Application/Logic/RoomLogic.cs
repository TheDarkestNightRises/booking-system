using BookingSystem.Application.LogicContracts;
using BookingSystem.Application.RepositoryContracts;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Application.Logic;

public class RoomLogic : IRoomLogic
{
    private readonly IRoomRepository _roomRepository;

    public RoomLogic(IRoomRepository roomRepository)
    {
        _roomRepository = roomRepository;
    }
    public async Task<List<Room>> GetAllRoomsAsync()
    {
        return await _roomRepository.GetAllRoomsAsync();
    }

    public async Task<Room?> GetRoomByIdAsync(int id)
    {
       return await _roomRepository.GetRoomByIdAsync(id);
    }
}
