using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Application.LogicContracts;

public interface IRoomLogic
{
    Task<List<Room>> GetAllRoomsAsync();
    Task<Room?> GetRoomByIdAsync(int id);
}
