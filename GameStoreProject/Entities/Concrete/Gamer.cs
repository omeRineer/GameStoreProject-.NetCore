﻿using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Gamer:User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
