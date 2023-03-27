using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models;
public class Reservation
{
    public int Id { get; set; }

    [Required]
    public DateTime DateTo { get; set; }

    [Required]
    public DateTime DateFrom { get; set; }

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "The number of reserved people must be greater than 0")]
    public int ReservedPeople { get; set; }

    [Required]
    public int RoomId { get; set; }
}

