using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Application.RepositoryContracts;
public interface IRoomRepository
{
    Task<List<Room>> GetAllRoomsAsync();
    Task<Room?> GetRoomByIdAsync(int id);

}

