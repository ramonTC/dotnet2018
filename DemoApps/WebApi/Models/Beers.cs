﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Beer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Code { get; set; }
    }
}
