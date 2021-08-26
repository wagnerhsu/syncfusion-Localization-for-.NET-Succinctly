using System;

namespace ClassLibraryDevelopers
{
    class Program
    {
        static void Main(string[] args)
        {
            LanguageProvider.Register(new StringTableProvider(ChineseResource.ResourceManager));
            Console.WriteLine(LanguageProvider.GetString("SomeName"));
        }
    }
}
