namespace BusinessCommunicator.Models
{
    public class Message : EntityBase
    {
        public string Description { get; set; }
        public User User { get; set; }

    }
}
