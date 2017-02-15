using System.Collections.Generic;

namespace SicIdev.API.Models
{
    public class PriseEnCharge
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public virtual ICollection<Selection> Selections { get; set; }

    }
}