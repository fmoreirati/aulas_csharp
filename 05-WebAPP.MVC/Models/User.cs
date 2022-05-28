using System.ComponentModel.DataAnnotations;

namespace _05_WebAPP.MVC.Models
{
    public class User
    {

        [Key]
        public long id { get; set; }
        public string? nome { get; set; }
        public string? nick { get; set; }
        public string? email { get; set; }
        public string? pass { get; set; }
        public bool ativo { get; set; } = true;
    }
}