﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Commons.Entities.User
{
    public class UserToken
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
