namespace CatFactPuller.Logic;

public class CatFactPuller : ICatFactPuller
{
    private readonly ICatFactService _catFactService;
    private readonly ICatFactStorageService _catFactStorageService;

    public CatFactPuller(ICatFactService catFactService, ICatFactStorageService catFactStorageService)
    {
        _catFactService = catFactService;
        _catFactStorageService = catFactStorageService;
    }

    public async Task PullCatFactsAsync()
    {
        var catFact = await _catFactService.FetchCatFactAsync();

        await _catFactStorageService.PersistAsync(catFact);
    }
}