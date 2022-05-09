﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ProFit.Models
{
    public class User : IdentityUser
    {
        public string Name {get; set;}
        public string Phone { get; set; }
        public string Role { get; set; }
    }
}
