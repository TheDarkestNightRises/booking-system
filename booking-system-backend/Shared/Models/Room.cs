using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models;
public class Room
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "The name is required.")]
    public string Name { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "The number of people must be greater than zero.")]
    public int NumberOfPeople { get; set; }

}
    

