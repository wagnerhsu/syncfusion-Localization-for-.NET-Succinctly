using System;

namespace ClassLibraryDevelopers
{
    class Program
    {
        static void Main(string[] args)
        {
            var provider = new StringTableProvider(ChineseResource.ResourceManager);
            LanguageProvider.Register(provider);
            Console.WriteLine(LanguageProvider.GetString("SomeName"));
            LanguageProvider.Unregister(provider);
            Console.WriteLine(LanguageProvider.GetString("SomeName"));
        }
    }
}
