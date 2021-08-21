using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Swift.Models
{
    [Table("UserAccount")]
    public class UserAccount
    {
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public string DateOfBirth { get; set; }
        public string Occupation { get; set; }

        public int Income { get; set; }

        public string Telephone { get; set; }
        public string Address { get; set; }
        public string Facebook { get; set; }
        public string Ig { get; set; }
    }
}