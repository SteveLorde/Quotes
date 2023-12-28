using Quotes.Data.Models;

namespace Quotes.Services.DataSeed;

public interface IDataSeed
{
    public Task<List<Quote>> GetSeededQuotes();
}