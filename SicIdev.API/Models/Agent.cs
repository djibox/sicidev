namespace SicIdev.API.Models
{
    public class Agent
    {
        public int Id { get; set; }
        public virtual string UserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public string FullName { get; set; }
        public string Telephone { get; set; }

    }
}