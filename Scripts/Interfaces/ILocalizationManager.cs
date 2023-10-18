namespace Itibsoft.LocalizationManager.Interfaces
{
    public interface ILocalizationManager
    {
        public void SetLanguage(Languages language);
        public void SetSheet(string[,] sheet);
        public void GetLanguages();
        public Languages GetCurrentLanguage();
        public string Localize(string code);
        
    }
}