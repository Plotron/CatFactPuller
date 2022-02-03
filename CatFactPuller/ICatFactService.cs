namespace CatFactPuller;

public interface ICatFactService
{
    Task<CatFact> FetchCatFactAsync();
}