﻿using System;
using System.Collections.Generic;

namespace webapi.Models
{
    public partial class Users
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
