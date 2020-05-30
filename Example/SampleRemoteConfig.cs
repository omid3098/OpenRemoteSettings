using System.Collections.Generic;
namespace OpenRemoteSettings.Example
{
    [System.Serializable]
    // This will be serialized into a JSON Address object
    public class SampleRemoteConfig
    {
        public float Version;
        public float Speed;
        public List<string> imageUrls;

        public SampleRemoteConfig()
        {
            // or set properties in default constructor to generate sample data
            Version = 0.1f;
            Speed = 10f;
            imageUrls = new List<string>()
            {
                "www.google.com",
            };
        }
    }
}