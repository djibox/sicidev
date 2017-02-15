using System.Collections.Generic;

namespace SicIdev.API.Models
{
    public class Departement
    {
        public int Id { get; set; }
        public string Designation { get; set; }
        public virtual ICollection<Selection> Selections { get; set; }

    }
}