using Itibsoft.LocalizationManager;
using UnityEngine;
using UnityEngine.UI;

namespace Itibsoft
{
    //[ExecuteInEditMode]
    public class LocalizationSync : MonoBehaviour
    {
        [Header("Table Id ")] 
        [SerializeField] private string _tableID;

        [SerializeField] private DownloaderTable _downloader;

        [SerializeField] private TextAsset _csvFile;

        [SerializeField] private Languages _languages;
        
        private LocalizationManager.LocalizationManager _localizationManager;
        
        private void Awake()
        {
            _localizationManager = new LocalizationManager.LocalizationManager();
            
            _localizationManager.SetSheet(CSVReader.SplitCsvGrid(_csvFile.text));
            
            _localizationManager.SetLanguage(_languages);
        }

        public void StartSync()
        {
            _downloader.DownloadTable(_tableID, OnRawLoaded);
        }

        private void OnRawLoaded(string text)
        {

#if UNITY_EDITOR
            string path = UnityEditor.EditorUtility.SaveFilePanel("Save Localization", Application.dataPath, "Localization", "csv");
            System.IO.File.WriteAllText(path, text);
            var filePath = (@"Assets\" + System.IO.Path.GetRelativePath(Application.dataPath, path)).Replace('\\' , '/');
            _csvFile = (TextAsset)UnityEditor.AssetDatabase.LoadAssetAtPath(filePath, typeof(TextAsset));
            Debug.Log(filePath);
#endif
        }
    }
}
