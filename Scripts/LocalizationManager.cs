using System;
using Itibsoft.LocalizationManager.Interfaces;

namespace Itibsoft.LocalizationManager
{
    public class LocalizationManager : ILocalizationManager
    {
        private Languages _currentLanguage;

        private static string[,] _sheet;

        private static int _column;
        
        public void SetLanguage(Languages language)
        {
            _currentLanguage = language;

            string languageCode = LanguagesHelper.GetLanguageCode(language);

            for (int i = 0; i < _sheet.GetLength(0); i++)
            {
                if (_sheet[i,0] == languageCode)
                {
                    _column = i;
                    return;
                }
            }
        }

        public void SetSheet(string[,] sheet)
        {
            _sheet = sheet;
        }

        public void GetLanguages()
        {
            
        }

        public Languages GetCurrentLanguage()
        {
            return _currentLanguage;
        }

        public string Localize(string code)
        {
            for (int i = 0; i < _sheet.GetLength(1); i++)
            {
                if (_sheet[0,i] == code)
                {
                    return _sheet[_column, i];
                }
            }

            return null;
        }
    }
}

