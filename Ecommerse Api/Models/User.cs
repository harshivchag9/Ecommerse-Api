﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Ecommerse_Api.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Roles { get; set; }
    }
}
