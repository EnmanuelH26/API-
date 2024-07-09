using System.ComponentModel.DataAnnotations;

namespace CAAPI.Model
{
    public class Contact
    {
        [Key]
        public int idContact { get; set; }
        public string name{ get; set; }
        public string email{ get; set; }
        public string phone{ get; set; }
    }
}
