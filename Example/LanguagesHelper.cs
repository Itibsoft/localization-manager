namespace Itibsoft.LocalizationManager
{
    public static class LanguagesHelper
    {
        private static string[] _codes = new []
            {"_ru", "_en", "_ro", "_fr"};
        
        public static string GetLanguageCode(Languages language)
        {
            return _codes[(int)language];
        }
    }
}