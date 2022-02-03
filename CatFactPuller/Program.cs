using CatFactPuller.Logic;
using SimpleInjector;

namespace CatFactPuller
{
    internal class Program
    {
        private static readonly Container Container;

        static Program()
        {
            Container = new Container();

            Container.Register<ICatFactService, CatFactService>();
            Container.Register<ICatFactStorageService, TextFileCatFactStorageService>();
            Container.Register<ICatFactPuller, Logic.CatFactPuller>();

            Container.Verify();
        }

        static async Task Main(string[] args)
        {
            var catFactPuller = Container.GetInstance<ICatFactPuller>();

            await catFactPuller.PullCatFactsAsync();
        }
    }
}