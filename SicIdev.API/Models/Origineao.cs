using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SicIdev.API.Models
{
    public class Origineao
    {
        public int Id { get; set; }
        public string Origine { get; set; }
        public virtual ICollection<Selection> Selections { get; set; }

    }
}