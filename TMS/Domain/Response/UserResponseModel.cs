﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Response
{
    public class UserResponseModel
    {
        public long Id { get; set; }
        public string UserName { get; set; } = null!;
        public string Email { get; set; } = null!;

    }
}
