using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MMC.WEB.Entities;
using MMC.WEB.Services;

namespace MMC.WEB.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly EventService _Eservice;
        private readonly SpeakerService _Sservice;
        public IEnumerable<Event> Events { get; set; }
        public IEnumerable<Speaker> Speakers { get; set; }
        public int eventCount { get; set; }
        public int speakerCount { get; set; }

        public IndexModel(ILogger<IndexModel> logger, EventService Eservice, SpeakerService Sservice)
        {
            _logger = logger;
            _Eservice = Eservice;
            _Sservice = Sservice;
        }

        public async Task OnGet()
        {
            Events = await _Eservice.FindAll();
            Speakers = await _Sservice.FindAll();
            eventCount = Events.Count();
            speakerCount = Speakers.Count();
        }
    }
}