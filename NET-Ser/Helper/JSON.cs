

using Newtonsoft.Json;

namespace Ventus.Helper
{
    public class JSON
    {
        public static string Serialize<T>(T obj)
        {
            var json = JsonConvert.SerializeObject(obj,Formatting.Indented);
            return json;
        }

        public static T Deserialize<T>(string json)
        {
            var obj = JsonConvert.DeserializeObject<T>(json);
            return obj;
        }
    }
}
