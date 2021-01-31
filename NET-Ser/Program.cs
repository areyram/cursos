using System;
using System.Drawing;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Ventus
{
    class Program
    {
        static void Main()
        {
            var obj = new BE.Person
            {
                ID = 123,
                Name = "Fulano de Tal",
                DOB = new DateTime(2015, 2, 21),
                FavoriteColorName = "Green",
                Token = 159632478,
                Comment = new BE.PersonComment
                {
                    Date = DateTime.Now,
                    Text = "Well, this escalated quickly"
                },
                Likes = new[] {"Dinosaurios", "Pizza"},
                Photo = File.ReadAllBytes("foto.jpg")
            };
            var xml = Helper.XML.Serialize<BE.Person>(obj);
            var o1 = Helper.XML.Deserialize<BE.Person>(xml);

            var json = Helper.JSON.Serialize<BE.Person>(obj);
            var o2 = Helper.JSON.Deserialize<BE.Person>(json);
            var j2 = Helper.JSON.Deserialize<JObject>(json);
        }
    }
}