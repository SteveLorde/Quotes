using Quotes.Data.Models;

namespace Quotes.Services.DataSeed;

public class DataSeed : IDataSeed
{
    private readonly HttpClient _http;

    public DataSeed(HttpClient http)
    {
        _http = http;
    }

    public async Task<List<Quote>> GetSeededQuotes()
    {
        var lol = await _http.GetAsync("");
        List<Quote> seededquotes = await lol.Content.ReadFromJsonAsync<List<Quote>>();
        return seededquotes;
    }
    
    
    
}