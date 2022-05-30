using System.Collections.Generic;

namespace BusinessCommunicator.Models
{
    public class User : EntityBase
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public Team Team { get; set; }
        public ICollection <Message> Messages { get; set; }

    }
}
