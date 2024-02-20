using MMC.WEB.Entities;

namespace MMC.WEB.Services;

public class EventService
{
    private readonly HttpClient _http;
    private readonly string _baseUrl;
    private string _controller = "Event";

    public EventService(HttpClient http, IConfiguration configuration)
    {
        _http = http;
        _baseUrl = configuration.GetValue<string>("ApiSettings:GatewayUrl");
    }

    public async Task<Event> Find(Guid id)
    {
        var response = await _http.GetFromJsonAsync<Event>($"{_baseUrl}gateway/{_controller}/{id}");
        return response;
    }

    public async Task<IEnumerable<Event>> FindAll()
    {
        var response = await _http.GetFromJsonAsync<IEnumerable<Event>>($"{_baseUrl}gateway/{_controller}");
        return response;
    }

    public async Task<Event> Create(Event @event)
    {
        var response = await _http.PostAsJsonAsync($"{_baseUrl}gateway/{_controller}", @event);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<Event>();
    }

    public async Task<Event> Update(Event @event)
    {
        var response = await _http.PutAsJsonAsync($"{_baseUrl}gateway/{_controller}", @event);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<Event>();
    }

    public async Task Delete(Guid id)
    {
        var response = await _http.DeleteAsync($"{_baseUrl}gateway/{_controller}/{id}");
        response.EnsureSuccessStatusCode();
    }

    public async Task<IEnumerable<City>> FindAllCities()
    {
        var response = await _http.GetFromJsonAsync<IEnumerable<City>>($"{_baseUrl}gateway/City");
        return response;
    }

    public async Task<IEnumerable<Theme>> FindAllThemes()
    {
        var response = await _http.GetFromJsonAsync<IEnumerable<Theme>>($"{_baseUrl}gateway/Theme");
        return response;
    }
}