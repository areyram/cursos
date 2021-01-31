using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Ventus.Helper
{
    public static class XML
    {
        public static string Serialize<T>(T obj)
        {
            var xs = new XmlSerializer(typeof(T));
            var ms = new MemoryStream();
            xs.Serialize(ms, obj);
            var s = Encoding.UTF8.GetString(ms.ToArray());
            return s;
        }

        public static T Deserialize<T>(string xml)
        {
            var xs = new XmlSerializer(typeof(T));
            var bytes = Encoding.UTF8.GetBytes(xml);
            var ms = new MemoryStream(bytes);
            var obj = (T)xs.Deserialize(ms);
            return obj;
        }
    }
}
