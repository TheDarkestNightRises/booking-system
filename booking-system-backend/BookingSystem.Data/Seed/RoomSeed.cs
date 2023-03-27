using Microsoft.EntityFrameworkCore;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Data.Seed;

public static class RoomSeed
{
    public static void SeedRooms(this ModelBuilder modelBuilder)
    {
        var rooms = new List<Room>
        {
            new Room { Id = 1, Name = "Single Bed", NumberOfPeople = 1 },
            new Room { Id = 2, Name = "Double Bed", NumberOfPeople = 2 },
            new Room { Id = 3, Name = "Twin Bed", NumberOfPeople = 2 },
            new Room { Id = 4, Name = "Triple", NumberOfPeople = 3 },
            new Room { Id = 5, Name = "Quad", NumberOfPeople = 4 },
            new Room { Id = 6, Name = "Queen Room", NumberOfPeople = 2 },
            new Room { Id = 7, Name = "King Room", NumberOfPeople = 2 },
            new Room { Id = 8, Name = "Suite", NumberOfPeople = 4 }
        };

        modelBuilder.Entity<Room>().HasData(rooms);
    }
}
