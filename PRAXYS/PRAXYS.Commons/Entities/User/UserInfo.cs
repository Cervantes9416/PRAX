using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PRAXYS.Commons.Entities.User
{
    public class UserInfo
    {
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string Password { get; set; }
        public bool Persitent { get; set; }
    }
}
