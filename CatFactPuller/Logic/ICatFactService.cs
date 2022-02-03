namespace CatFactPuller.Logic;

public interface ICatFactService
{
    Task<CatFact> FetchCatFactAsync();
}