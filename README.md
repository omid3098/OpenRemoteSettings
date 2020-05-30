# OpenRemoteSettings

## Table of Contents

- [Introduction](#introduction)
- [How To Install](#how-to-install)
- [License](#license)
- [Contacts](#contacts)

## Introduction

1- Create your own config class and make is serializable:

```#cs
    [System.Serializable]
    public class RemoteConfig
    {
        public float Version;
        public float Speed;
        public List<string> imageUrls;

        public RemoteConfig()
        {
            Version = 0.1f;Speed = 10f;imageUrls = new List<string>(){"link1.com","link2.com",};
        }
    }
```

2- Make a valid Json(YAML or any other format) from your class. (you can use [csharp2json.io](https://csharp2json.io/) just make sure to turn off Camel case this site)

```@json
{
  "Version": 0.3,
  "Speed": 10.0,
  "imageUrls": [
    "link1.com",
    "link2.com"
  ]
}
```

4- Save and upload your json file to your website and have a direct URL.

3- Call `RemoteSettings.DownloadConfigAsync(configURL, OnDownloadComplete);` and wait for OnDownloadComplete to finish.
OnComplete action will be called containing your config file as a string and you can parse it using [JsonUtility](https://docs.unity3d.com/Manual/JSONSerialization.html), [MessagePack](https://github.com/neuecc/MessagePack-CSharp) or any other deserializer.

```#cs
        string configPath = "https://www.my-website.com/game-config.json";
        void Start()
        {
            RemoteSettings.DownloadConfigAsync(configPath, OnDownloadComplete);
        }

        private void OnDownloadComplete(string remoteConfig)
        {
            Debug.Log("Download Config Complete: \n" + remoteConfig);
            SampleRemoteConfig config = JsonUtility.FromJson<SampleRemoteConfig>(remoteConfig);
        }
```

## How To Install

### Method 1

Add to your project `manifest.json`:

```#json
{
  "dependencies": {
    "com.omid3098.openremotesettings": "https://github.com/omid3098/OpenRemoteSettings.git"
  }
}
```

### Method 2

Download and extract this repository inside your project.

## License

[MIT License](LICENSE)

## Contacts

Telegram: [@omid3098](https://t.me/omid3098)  
E-Mail: [info@omid-saadat.com](mailto:info@omid-saadat.com)
