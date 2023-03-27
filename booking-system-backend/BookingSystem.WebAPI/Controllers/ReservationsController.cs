using BookingSystem.Application.Logic;
using BookingSystem.Application.LogicContracts;
using BookingSystem.Shared.Dtos;
using BookingSystem.WebAPI.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.Models;

namespace BookingSystem.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ReservationsController : ControllerBase
{
    private readonly IReservationLogic _reservationLogic;

    public ReservationsController(IReservationLogic reservationLogic)
    {
        _reservationLogic = reservationLogic;
    }

    [HttpGet]
    public async Task<ActionResult<List<ReservationReadDto>>> GetAllReservationsAsync()
    {
        try
        {
            var reservations = await _reservationLogic.GetAllReservationsAsync();
            if (reservations is null)
            {
                return NotFound();
            }
            else
            {
                return Ok(reservations.ToReservationReadDtos());
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
        }
    }

    [HttpPost]
    public async Task<ActionResult<ReservationReadDto>> ReserveRoomAsync(ReservationCreateDto reservation)
    {
        try
        {
            var createdReservation = await _reservationLogic.ReserveRoomAsync(reservation.ToReservation());
            return Ok(createdReservation.ToReservationReadDto());
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return StatusCode(StatusCodes.Status500InternalServerError, "Server error");
        }
    }
}

