namespace Itibsoft.LocalizationManager.Interfaces
{
    public interface ILocalizationManager
    {
        public void SetLanguage(Languages language);
        public Languages GetCurrentLanguage();
        public string Localize(string code);
    }
}