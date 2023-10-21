using System.Collections.Generic;
using UnityEngine;

namespace Itibsoft
{
    [CreateAssetMenu(fileName = "LanguagesLocalization", menuName = "Localization/LanguagesLocalization")]
    public class LanguagesLocalization : ScriptableObject
    {
        public List<string> Languages => _languages;
        
        [SerializeField] private List<string> _languages;
    }
}
