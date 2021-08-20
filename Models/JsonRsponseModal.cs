using System;

namespace Swift.Models
{
    public class JsonRespons
    {
        public string Status { get; set; }
        public string Msg { get; set; }
    }

    public class UserResponse
    {
        public string Status { get; set; }
        public string Msg { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

        public string Occupation { get; set; }

        public int Income { get; set; }

        public string Telephone { get; set; }
        public string Address { get; set; }
        public string Facebook { get; set; }
        public string Ig { get; set; }
    }
}