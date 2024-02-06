using MMC.WEB.Entities;

namespace MMC.WEB.Services;

public class ValidatorService
{
    private readonly HttpClient _http;
    private readonly string _baseUrl;
    private string _controller = "JoinEvent";

    public ValidatorService(HttpClient http, IConfiguration configuration)
    {
        _http = http;
        _baseUrl = configuration.GetValue<string>("ApiSettings:ValidatorUrl");
    }

    public async Task<IEnumerable<JoinEvent>> FindAll()
    {
        var response = await _http.GetFromJsonAsync<IEnumerable<JoinEvent>>($"{_baseUrl}api/{_controller}");
        return response;
    }

    public async Task<JoinEvent> Create(JoinEvent join)
    {
        var response = await _http.PostAsJsonAsync($"{_baseUrl}api/{_controller}", join);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<JoinEvent>();
    }

    public async Task<JoinEvent> Update(int id, JoinEvent join)
    {
        var response = await _http.PutAsJsonAsync($"{_baseUrl}api/{_controller}/{id}", join);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<JoinEvent>();
    }
}