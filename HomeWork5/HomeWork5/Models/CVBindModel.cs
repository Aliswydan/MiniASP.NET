using System.ComponentModel.DataAnnotations;

namespace HomeWork5.Models
{
    public class CVBindModel
    {

        [Required]
        public string FirstName { get; set; }

        [Required]

        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; } 

        [Required]
        public string Nationality { get; set; }

        [Required]
        public string Sex { get; set; }




        [Required]
        public List<string> Skills { get; set; } = new List<string>();




        [Required]
        [EmailAddress]
 
        public string Email { get; set; }



        [Required]
        [Compare("Email", ErrorMessage = "the email and confirmtion email do not match")]
        [EmailAddress]
        public string EmailConfirm { get; set; }




        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "password must be at least 8 character")]
        [RegularExpression(@"(?=.*[a-zA-Z])(?=.*\d)(?=.*[^\da-zA-Z]).*$", ErrorMessage = "password must contain at least one letter ,one digit ,and one special character")]
        public string Password { get; set; }



        [Required]
        public int val1 { get; set; }



        [Required]
        public int val2 { get; set; }



        [Required]
        public int val3 { get; set; }



        [Required(ErrorMessage = "Photo is required")]
        [Display(Name = "Photo")]
        [DataType (DataType.Upload)]
        public IFormFile Photo { get; set; }
    }
}
