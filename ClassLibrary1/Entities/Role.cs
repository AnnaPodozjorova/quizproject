using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Domain.Entities
{
    public class Role
    {
        public Role()
        {
            RoleUser = new HashSet<RoleUser>();
        }
        public int RoleID { get; set; }
        public string Title { get; set; }
        public ICollection<RoleUser> RoleUser { get; set; }
    }
}
