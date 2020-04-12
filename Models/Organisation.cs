using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Interpol.Models {
    public class Organisation {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public Criminal Boss { get; set; }
        public List<Criminal> Members { get; set; }
    }
}