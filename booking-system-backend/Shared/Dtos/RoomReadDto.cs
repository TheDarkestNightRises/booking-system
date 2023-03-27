using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Shared.Dtos;

public class RoomReadDto
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int NumberOfPeople { get; set; }

}
