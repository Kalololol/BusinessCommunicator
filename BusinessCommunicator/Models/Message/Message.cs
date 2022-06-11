using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BusinessCommunicator.Models
{
    public class Message : EntityBase
    {
        [DisplayName("Ogłoszenia")]
        [Required(ErrorMessage = "Pole opis nie może być puste")]
        [MaxLength(1000)]
        public string Description { get; set; }

        public User User { get; set; }

    }
}
