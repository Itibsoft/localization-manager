namespace Itibsoft.LocalizationManager.Interfaces
{
    public interface ILocalizationManager
    {
        public Languages GetCurrentLanguage();
        public string Localize(string code);
    }
}