using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBlazorApp.Data.Model
{
    public class AspNetUsers
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string NormalizeUserName { get; set; }
        public string Email { get; set; }
        public string NorlizedEmail { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public byte PhoneNumberConfirmed { get; set; }
        public byte TwoFactorEnabled { get; set; }
        public string LockoutEnd { get; set; }
     
    }
    
}
