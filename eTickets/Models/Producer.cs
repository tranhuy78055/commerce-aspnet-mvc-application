using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer
    {
        [Key]
        public int ProducerId { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FulllName { get; set; } 
        public string Bio { get; set; }

        // Relationship
        public List<Movie> Movies { get; set; }
    }
}
