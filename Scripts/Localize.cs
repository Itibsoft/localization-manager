using System;
using UnityEngine;
using UnityEngine.UI;

namespace Itibsoft
{
    [RequireComponent(typeof(Text))]
    public class Localize : MonoBehaviour
    {
        [SerializeField] private string _id;
        
        [SerializeField] private Text _text;

        private LocalizationManager.LocalizationManager _localizationManager;
        private void Start()
        {
            _localizationManager = new LocalizationManager.LocalizationManager();

            LocalizeHandler();
        }

        private void LocalizeHandler()
        {
            var localizeWord = _localizationManager.Localize(_id);

            _text.text += localizeWord;
        }
    }
}
