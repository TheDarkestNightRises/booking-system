using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Shared.Dtos;

public class ReservationCreateDto
{
    public DateTime DateFrom { get; set; }
    public DateTime DateTo { get; set; }

    public int ReservedPeople { get; set; }
    public int RoomId { get; set; }
}
