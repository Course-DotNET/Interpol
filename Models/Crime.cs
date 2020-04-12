using System;
using System.ComponentModel.DataAnnotations;

namespace Interpol.Models {
    public class Crime {
        [Key] public double Id { get; set;}
        [Required] public DateTime Date { get; set;}
    }
}