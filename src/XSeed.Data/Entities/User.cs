using System;

namespace XSeed.Data.Entities
{
    public class User
    {
        public long Id { get; set; }

        public string Email { get; set; }

        public string Mobile { get; set; }

        public string Username { get; set; }

        public string Avatar { get; set; }

        public string Password { get; set; }

        public int LoginCount { get; set; }

        public DateTime LastLogin { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
