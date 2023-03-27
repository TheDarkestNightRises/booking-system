using BookingSystem.Shared.Dtos;
using Shared.Models;

namespace BookingSystem.WebAPI.Extensions;

public static class RoomConvertExtensions
{
    public static RoomReadDto ToRoomReadDto(this Room room)
    {
        return new RoomReadDto
        {
            Id = room.Id,
            Name = room.Name,
            NumberOfPeople = room.NumberOfPeople
        };
    }

    public static IEnumerable<RoomReadDto> ToRoomReadDtos(this IEnumerable<Room> rooms)
    {
        return rooms.Select(room => room.ToRoomReadDto());
    }
}

