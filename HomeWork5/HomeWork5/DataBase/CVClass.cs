using System.ComponentModel.DataAnnotations;

namespace HomeWork5.DataBase
{
    public class CVClass
    {
        [Key]
        public int CVId { get; set; }
 
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Birthday { get; set; }

        public string Nationality { get; set; }

        public string Sex { get; set; }

        public string Skills { get; set; }

        public string Email { get; set; }

        public string Password { get; set; } 

        public string Photo { get; set; }
    }
}
