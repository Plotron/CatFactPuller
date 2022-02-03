namespace CatFactPuller.Logic;

public interface ICatFactStorageService
{
    Task PersistAsync(CatFact catFact);
}