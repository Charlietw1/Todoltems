using System.ComponentModel.DataAnnotations;

namespace Todoltems.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public String Firstname { get; set; }
        [Required]
        public String Lastname { get; set; }
        [Required]
        public String Email { get; set; }
    }
}
