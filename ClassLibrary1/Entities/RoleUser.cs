using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Domain.Entities
{
    public class RoleUser
    {
        public int RoleUserId { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
