using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

namespace Itibsoft.LocalizationManager
{
    public class DownloaderTable : MonoBehaviour
    {
        private const string URLTable = "https://docs.google.com/spreadsheets/d/*/gviz/tq?tqx=out:csv&sheet={{LocalizationTable}}";

        public void DownloadTable(string sheetId, Action<string> onSheetLoadedAction)
        {
            var currentUrl = URLTable.Replace("*", sheetId);
            StartCoroutine(DownloadRawTable(currentUrl, onSheetLoadedAction));
        }

        private IEnumerator DownloadRawTable(string currentUrl, Action<string> callback)
        {
            using (UnityWebRequest request = UnityWebRequest.Get(currentUrl))
            {
                yield return request.SendWebRequest();

                if (request.result == UnityWebRequest.Result.ConnectionError 
                    || request.result == UnityWebRequest.Result.ProtocolError 
                    || request.result == UnityWebRequest.Result.DataProcessingError)
                {
                    Debug.LogError($"Error download! {request.error}");   
                }
                else
                {
                    Debug.Log("<color=green>Successful download</color>");
                    Debug.Log(request.downloadHandler.text);

                    callback(request.downloadHandler.text);
                }
            }

            yield return null;
        }
    }
}
