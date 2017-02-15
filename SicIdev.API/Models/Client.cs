using System.Collections.Generic;

namespace SicIdev.API.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public string Details { get; set; }
        public virtual ICollection<Selection> Selections { get; set; }
    }
}