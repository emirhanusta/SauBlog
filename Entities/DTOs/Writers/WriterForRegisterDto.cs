﻿using Entities.DTOs.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Writers
{
    public class WriterForRegisterDto : UserForRegisterDto
    {
        public string NickName { get; set; }
    }
}
