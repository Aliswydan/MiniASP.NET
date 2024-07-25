using HomeWork5.Commands;
using HomeWork5.DataBase;
using HomeWork5.Models;
using HomeWork5.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HomeWork5.Pages
{
    public class CreateCVModel : PageModel
    {
        private readonly ICVServices _cvservices;

        [BindProperty]
        public CVBindModel input { get; set; }
        
        public CVViewModel view { get; set; }

        public CreateCVModel(ICVServices cvservices)

        {
           _cvservices = cvservices;
           
        }

        public List<SelectListItem> skillsList { get; set; } = new List<SelectListItem>()
        {
            new SelectListItem {Text = "java" , Value = "java"},
            new SelectListItem {Text = "Python" , Value = "Python"},
            new SelectListItem {Text = "Asp" , Value = "Asp"}
            
        };

        public IEnumerable<SelectListItem> Nationalities { get; set; } = new List<SelectListItem>()
        {
            new SelectListItem {Text="USA" , Value = "USA"},
            new SelectListItem {Text="UK" , Value = "USA"},
            new SelectListItem {Text="LEBANON" , Value = "LEBANON"},
            new SelectListItem {Text="Canada" , Value = "Canada"},
        };


        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if((input.val1 + input.val2) != input.val3)
            {
                ModelState.AddModelError(string.Empty, "val1 + val2 must equal val3");

            }
            if (!ModelState.IsValid)
            {
                Console.WriteLine("Inputs:");
                Console.WriteLine(input.FirstName.ToString());
                Console.WriteLine(input.LastName.ToString());
                Console.WriteLine(input.Nationality.ToString());
                foreach (var skill in input.Skills)
                {
                    Console.WriteLine(skill);  
                }
                Console.WriteLine(input.Sex.ToString());
                Console.WriteLine(input.Password.ToString());
                Console.WriteLine(input.val3.ToString());
                Console.WriteLine(input.Photo.FileName);
                return Page();
            }
            Console.WriteLine("Inputs:");
            Console.WriteLine(input.FirstName.ToString());
            Console.WriteLine(input.LastName.ToString());
            Console.WriteLine(input.Nationality.ToString());
            foreach (var skill in input.Skills)
            {
                Console.WriteLine(skill);
            }
            Console.WriteLine(input.Sex.ToString());

            var cmd = new CVCommands
            {
                FirstName = input.FirstName,
                LastName = input.LastName,
                Nationality = input.Nationality,
                Skills = string.Join(" , ", input.Skills),
                Password = input.Password,
                Sex = input.Sex,
                Email = input.Email,
                Birthday = input.Birthday,
                Photo = input.Photo.FileName
            };

            int id = await _cvservices.AddCV(cmd);
            return RedirectToPage("/VeiwCVById" ,new { id = id});
            
        }
    }
}
