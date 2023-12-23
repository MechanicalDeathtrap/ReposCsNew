using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyORM
{
    public class UserData
    {
        public int ID { get; set; }
        public string TextInfo { get; set; }
        public string ElementID { get; set; }
        public string ImageDataURL { get; set; }

        public UserData( string text, string elementId, string imageData)
        {
            TextInfo = text;
            ElementID = elementId;
            ImageDataURL = imageData;
        }

        public UserData() { }
    }
}
