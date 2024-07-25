using HomeWork5.DataBase;
using HomeWork5.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomeWork5.Pages
{
    public class VeiwCVByIdModel : PageModel
    {
        public ICVServices _services;

        public VeiwCVByIdModel(ICVServices services)
        {
            _services = services;
        }
        public CVClass cv { get; set; }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            cv = await _services.GetCVById(id);
            return Page();
        }

    }
}
