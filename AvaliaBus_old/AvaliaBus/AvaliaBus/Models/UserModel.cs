using System;
using SQLite;

namespace AvaliaBus.Models
{
    public class UserModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Genre { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsRemember { get; set; }
        public bool IsUser { get; set; }
        public bool IsAdmin { get; set; }

    }
}
