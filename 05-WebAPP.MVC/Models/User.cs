using System.ComponentModel.DataAnnotations;

namespace _05_WebAPP.MVC.Models
{
    public class User
    {

        [Key]
        public long id { get; set; }

        [Required]
        public string nome { get; set; }

        public string? nick { get; set; }

        [Required]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        [StringLength(150, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 8)]
        public string pass { get; set; }

        public bool ativo { get; set; } = true;
    }
}