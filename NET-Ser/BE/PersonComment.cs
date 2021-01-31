using System;
using System.Xml.Serialization;

namespace Ventus.BE
{
    public class PersonComment
    {
        [XmlAttribute]
        public DateTime Date { get; set; }
        [XmlText]
        public string Text { get; set; }
    }
}