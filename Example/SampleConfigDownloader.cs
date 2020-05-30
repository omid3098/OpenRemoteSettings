using UnityEngine;
using UnityEngine.UI;

namespace OpenRemoteSettings.Example
{

    public class SampleConfigDownloader : MonoBehaviour
    {
        [SerializeField] Text text;
        [SerializeField] string configPath = "https://www.my-website.com/game-config.json";
        void Start()
        {

            Debug.Log("Downloading Config from " + configPath);
            RemoteSettings.DownloadConfigAsync(configPath, OnDownloadComplete);
        }

        private void OnDownloadComplete(string remoteConfig)
        {
            Debug.Log("Download Config Complete: \n" + remoteConfig);
            SampleRemoteConfig config = JsonUtility.FromJson<SampleRemoteConfig>(remoteConfig);
            text.text = remoteConfig;
        }
    }
}