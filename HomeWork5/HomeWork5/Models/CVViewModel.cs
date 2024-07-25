using System.ComponentModel.DataAnnotations;

namespace HomeWork5.Models
{
    public class CVViewModel 
    {


        [Required(ErrorMessage ="First Name is required")]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }



        [Required(ErrorMessage = "Last Name is required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }



        [Required(ErrorMessage ="Birthday is required")]
        [DataType(DataType.Date)]

        [Display(Name = "Birthday")]
        public DateTime Birthday { get; set; }




        [Required(ErrorMessage = "Nationality is required")]
        [Display(Name = "Nationality")]
        public string Nationality { get; set; }



        [Required(ErrorMessage = "sex is required")]
        [Display(Name = "Sex")]
        public string Sex { get; set; }




        [Required(ErrorMessage = "Skills is required")]
        [Display(Name = "Skills")]
        public List<string> Skills { get; set; } =new List<string>();




        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage ="Invalid Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }



        [Required(ErrorMessage = "EmailConfirm is required")]
        [Display(Name = "EmailConfirm")]
        [Compare("Email",ErrorMessage ="the email and confirmtion email do not match")]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string EmailConfirm { get; set; }




        [Required(ErrorMessage = "Password is required")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [StringLength(100,MinimumLength = 8,ErrorMessage ="password must be at least 8 character")]
        [RegularExpression(@"(?=.*[a-zA-Z])(?=.*\d)(?=.*[^\da-zA-Z]).*$",ErrorMessage ="password must contain at least one letter ,one digit ,and one special character")]
        public string Password { get; set; }



        [Required(ErrorMessage = "val1 is required")]
        [Display(Name = "val1")]
        public int val1 { get; set; }



        [Required(ErrorMessage = "val2 is required")]
        [Display(Name = "val2")]
        public int val2 { get; set; }



        [Required(ErrorMessage = "val3 is required")]
        [Display(Name = "val3")]
        public int val3 { get; set; }



        [Required(ErrorMessage = "Photo is required")]
        [Display(Name = "Photo")]
        [DataType(DataType.Upload)]
        public IFormFile Photo { get; set; }
    }
}
