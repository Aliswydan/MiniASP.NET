using HomeWork5.DataBase;
using HomeWork5.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomeWork5.Pages
{
    public class VeiwAllCVModel : PageModel
    {
        public ICVServices _CVServices { get; set; }
        public VeiwAllCVModel(ICVServices services) 
        {
            _CVServices = services;
        } 
        public List<CVClass> cvs {  get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            cvs = await _CVServices.GetCV();

            return Page();

        }
    }
}
