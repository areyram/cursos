using System;
using System.Drawing;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Ventus.BE
{
    [Serializable]
    public class Person
    {
        [XmlAttribute(AttributeName = "id")]
        public int ID { get; set; }

        public string Name { get; set; }

        public DateTime DOB { get; set; }

        public Color FavoriteColor => Color.FromName(FavoriteColorName);
 
        [XmlElement(ElementName = "FavColor")]
        [JsonProperty("fav-color")]
        public string FavoriteColorName { get; set; }

        [XmlIgnore]
        public int Token { get; set; }

        public PersonComment Comment { get; set; }

        public string[] Likes { get; set; }

        public byte[] Photo { get; set; }
        //TODO: Blob
    }
}