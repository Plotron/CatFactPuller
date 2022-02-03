namespace CatFactPuller;

public interface ICatFactStorageService
{
    Task PersistAsync(CatFact catFact);
}