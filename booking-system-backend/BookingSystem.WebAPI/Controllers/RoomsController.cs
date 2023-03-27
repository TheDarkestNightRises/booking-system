using BookingSystem.Application.LogicContracts;
using BookingSystem.Application.RepositoryContracts;
using BookingSystem.Shared.Dtos;
using BookingSystem.WebAPI.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.Models;

namespace BookingSystem.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RoomsController : ControllerBase
{
    private readonly IRoomLogic _roomLogic;

    public RoomsController(IRoomLogic roomLogic)
    {
        _roomLogic = roomLogic;
    }

    [HttpGet]
    public async Task<ActionResult<List<RoomReadDto>>> GetAllRoomsAsync()
    {
        try
        {
            var rooms = await _roomLogic.GetAllRoomsAsync();
            if (rooms is null)
            {
                return NotFound();
            }
            else
            {
                return Ok(rooms.ToRoomReadDtos());
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
        }
    }
}

