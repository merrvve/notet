using notet.MODEL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notet.MODEL.Entities
{
    public class AppUser : BaseEntity
    {

        [MaxLength(15, ErrorMessage = "Kullanıcı adı en fazla 15 karakterden oluşabilir")]
        public string UserName { get; set; }

        public string Password { get; set; }

        // [Required(ErrorMessage ="Zorunlu Alan")]
        public string? Email { get; set; }
        public Role Role { get; set; }
    }
}
