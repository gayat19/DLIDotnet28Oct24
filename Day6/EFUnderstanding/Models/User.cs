using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFUnderstanding.Models
{
    public enum UserStatus{ Active,InActive,Barred}
    public class User
    {
        [Key]
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty ;
        public  UserStatus Status { get; set; } =UserStatus.InActive;
    }
}
