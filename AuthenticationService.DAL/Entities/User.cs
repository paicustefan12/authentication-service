﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationService.DAL.Entities
{
    public class User : IdentityUser<int>
    {
        public string RefreshToken { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
