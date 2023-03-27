using Microsoft.EntityFrameworkCore;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Data.Seed;

public static class ReservationSeed
{
    public static void SeedReservations(this ModelBuilder modelBuilder)
    {
        var reservations = new List<Reservation>
        {
            new Reservation { Id = 1, DateFrom = new DateTime(2022, 1, 1), DateTo = new DateTime(2022, 1, 7), ReservedPeople = 2, RoomId = 1 },
            new Reservation { Id = 2, DateFrom = new DateTime(2022, 1, 3), DateTo = new DateTime(2022, 1, 5), ReservedPeople = 1, RoomId = 2 },
            new Reservation { Id = 3, DateFrom = new DateTime(2022, 1, 10), DateTo = new DateTime(2022, 1, 15), ReservedPeople = 3, RoomId = 3 },
            new Reservation { Id = 4, DateFrom = new DateTime(2022, 1, 17), DateTo = new DateTime(2022, 1, 22), ReservedPeople = 2, RoomId = 4 },
            new Reservation { Id = 5, DateFrom = new DateTime(2022, 2, 1), DateTo = new DateTime(2022, 2, 8), ReservedPeople = 1, RoomId = 5 },
            new Reservation { Id = 6, DateFrom = new DateTime(2022, 2, 3), DateTo = new DateTime(2022, 2, 10), ReservedPeople = 2, RoomId = 6 },
            new Reservation { Id = 7, DateFrom = new DateTime(2022, 2, 12), DateTo = new DateTime(2022, 2, 16), ReservedPeople = 2, RoomId = 7 },
            new Reservation { Id = 8, DateFrom = new DateTime(2022, 2, 25), DateTo = new DateTime(2022, 2, 28), ReservedPeople = 1, RoomId = 8 },
        };

        modelBuilder.Entity<Reservation>().HasData(reservations);
    }

}
