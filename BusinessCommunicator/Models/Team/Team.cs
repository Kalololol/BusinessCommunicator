using BusinessCommunicator.Models;
using System.Collections.Generic;

namespace BusinessCommunicator.Models
{
    public class Team : EntityBase
    {
        public string Name { get; set; }
        public ICollection <User> Users { get; set; }
        public ICollection <Message> Messages { get; set; }


    }
}
