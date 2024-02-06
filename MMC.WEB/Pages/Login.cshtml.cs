using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MMC.WEB.Pages;

public class LoginModel : PageModel
{
    public void OnGet()
    {
    }


    public async Task<IActionResult> OnPostLogin()
    {
        return RedirectToPage("/Index");
    }
}
