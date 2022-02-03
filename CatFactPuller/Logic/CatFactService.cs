using System.Configuration;
using RestSharp;

namespace CatFactPuller.Logic;

public class CatFactService : ICatFactService
{
    private static readonly string Uri = ConfigurationManager.AppSettings.Get("catFactServiceUri");

    public async Task<CatFact> FetchCatFactAsync()
    {
        var client = new RestClient(Uri);

        var request = new RestRequest();

        return await client.GetAsync<CatFact>(request) 
            ?? throw new CatFactMissingException($"API endpoint {Uri} returned null.");
    }
}