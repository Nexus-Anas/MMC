using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MMC.WEB.Pages;

public class LoginModel : PageModel
{
    [BindProperty]
    public string LUsername { get; set; }
    [BindProperty]
    public string LPassword { get; set; }
    public string Msg { get; set; } = string.Empty;
    public void OnGet()
    {

    }


    public async Task<IActionResult> OnPostLogin()
    {
        if (LUsername != "adminMMC" || LPassword != "admin123456")
        {
            Msg = "Invalid username or password!";
            return Page();
        }
        return RedirectToPage("/Index");
    }
}
