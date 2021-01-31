using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventus
{

    public class PersonJson
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string FavoriteColor { get; set; }
        public string favcolor { get; set; }
        public int Token { get; set; }
        public PersonCommentJson Comment { get; set; }
        public string[] Likes { get; set; }
    }

    public class PersonCommentJson
    {
        public DateTime Date { get; set; }
        public string Text { get; set; }
    }
}
