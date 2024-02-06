using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MMC.WEB.Entities;
using MMC.WEB.Services;

namespace MMC.WEB.Pages.Participations;

public class IndexModel : PageModel
{
    private readonly ValidatorService _service;
    public IndexModel(ValidatorService service) => _service = service;



    public IEnumerable<JoinEvent> JoinEvents { get; private set; }




    public async Task OnGet()
        => JoinEvents = await _service.FindAll();


    //public async Task<IActionResult> OnPostApprove()
    //{
    //    //Speaker.PicturePath = await InsertImagesAsync();
    //    //Speaker.MVP = false;
    //    //Speaker.MCT = false;
    //    //Speaker.Gender = 'M';
    //    //Speaker.UserId = new Guid("3e89166a-4aae-42c5-9c2e-bb2d48c0a348");

    //    //await _service.Create(Speaker);
    //    //return RedirectToPage("/Speakers/Index");
    //}
}
