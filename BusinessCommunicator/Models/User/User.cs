using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BusinessCommunicator.Models
{
    public class User : EntityBase
    {
        

        [DisplayName("Nazwa użytkownika")]
        [Required(ErrorMessage = "Podaj nazwę użytkownika!")]
        [MaxLength(75)]
        public string Name { get; set; }
        [DisplayName("E-mail: ")]
        [Required(ErrorMessage = "Adres e-mail jest wymagany!")]
        [MaxLength(125)]
        public string Email { get; set; }
        [DisplayName("Hasło:")]
        [Required(ErrorMessage = "Hasło jest wymagane!")]
        [MaxLength(20)]
        public string Password { get; set; }

        public ICollection <Message> Messages { get; set; }

    }
}

