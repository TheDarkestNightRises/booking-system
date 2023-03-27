using BookingSystem.Data.Seed;
using Microsoft.EntityFrameworkCore;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Data.Context;

public class DataContext : DbContext
{
    public string Connection { get; } = "Data Source=..\\BookingSystem.Data\\booking.db";
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(Connection);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.SeedRooms();
        modelBuilder.SeedReservations();
        Database.Migrate();
    }

    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<Room> Rooms { get; set; }
}
