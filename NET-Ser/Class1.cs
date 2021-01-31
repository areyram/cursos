using System;

namespace Ventus
{

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true),
     System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
    public class PersonXml
    {
        /// <remarks/>
        public string Name { get; set; }

        /// <remarks/>
        public System.DateTime DOB { get; set; }

        /// <remarks/>
        public string FavColor { get; set; }

        /// <remarks/>
        public PersonCommentXml Comment { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItem(IsNullable = false)]
        public string[] Likes { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public byte id { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class PersonCommentXml
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public System.DateTime Date { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlText()]
        public string Value { get; set; }
    }


}
