namespace Itibsoft.LocalizationManager
{
    public enum Languages
    {
        Russian,
        English,
        Romania,
        France,
        
    }

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