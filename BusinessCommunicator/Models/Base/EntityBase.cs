using System.ComponentModel.DataAnnotations;

namespace BusinessCommunicator.Models
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; }
        public bool Active { get; set; }
    }
}
