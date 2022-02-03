using System.Configuration;
using System.Text.Json;

namespace CatFactPuller.Logic;

public class TextFileCatFactStorageService : ICatFactStorageService
{
    private static readonly string FileName = ConfigurationManager.AppSettings.Get("catFactStorageFileName");

    public async Task PersistAsync(CatFact catFact)
    {
        await using StreamWriter outputFile = new StreamWriter(FileName, true);

        await outputFile.WriteLineAsync(JsonSerializer.Serialize(catFact));
    }
}