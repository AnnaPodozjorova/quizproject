using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Domain.Entities
{
    public class User
    {
        public User()
        {
            RoleUser = new HashSet<RoleUser>();
            QuizUser = new HashSet<QuizUser>();
        }
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string telephone { get; set; }
        public string Email { get; set; }
        public ICollection<RoleUser> RoleUser { get; set; }
        public ICollection<QuizUser> QuizUser { get; set; }
    }
}
