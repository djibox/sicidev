using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SicIdev.API.Models
{
    public class Domaine
    {
        public int Id { get; set; }
        public string Designation { get; set; }
        [Required]
        [DisplayName("Département du domaine")]
        public virtual int DepartementId { get; set; }
        public virtual Departement Departement { get; set; }
    }
}