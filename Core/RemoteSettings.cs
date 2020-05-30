using System;
using UnityEngine;
using UnityEngine.Networking;

namespace OpenRemoteSettings
{
    public class RemoteSettings
    {
        public static void DownloadConfigAsync(string path, Action<string> OnComplete)
        {
            UnityWebRequest www = new UnityWebRequest(path)
            {
                downloadHandler = new DownloadHandlerBuffer()
            };
            var request = www.SendWebRequest();
            request.completed += (asyncOperation) =>
            {
                if (request.webRequest.isNetworkError || request.webRequest.isHttpError)
                {
                    Debug.LogError("Could not download from " + path);
                }
                else
                {
                    OnComplete?.Invoke(www.downloadHandler.text);
                }
            };
        }
    }
}