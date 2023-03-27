using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Application.LogicContracts;

public interface IReservationLogic
{
    Task<Reservation> ReserveRoomAsync(Reservation reservation);
    Task<List<Reservation>> GetAllReservationsAsync();
}
