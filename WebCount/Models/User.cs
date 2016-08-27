using System;
using System.Collections.Generic;

namespace WebCount.Models
{
    public class User : IBaseModel
    {
        public User()
        {
            UserRoles = new List<UserRole>();
        }

        public int Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string HashedPassword { get; set; }

        public string Salt { get; set; }

        public bool IsLocked { get; set; }

        public DateTime DateCreated { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }
    }
}