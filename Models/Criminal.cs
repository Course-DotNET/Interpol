using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Interpol.Models {
    public class Criminal {
        [Key] public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public byte Age { get; set; }
        public bool Sex { get; set; }
        public List<Crime> Crimes { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public List<string> ExtraSigns { get; set; }
        public string LastAccomodation { get; set; }
        public List<Organisation> Organisations { get; set; }
    }
}