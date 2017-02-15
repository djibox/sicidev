﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SicIdev.API.Models
{
    public class Typeao
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public virtual ICollection<Selection> Selections { get; set; }

    }
}