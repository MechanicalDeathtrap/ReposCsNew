

namespace MyORM
{
    public class PopularList
    {
        public int ID { get; set; }
        public string ImageDataURL { get; set; }
        public string ElementName { get; set; }
        public string Link {  get; set; }

        public PopularList(int id,string imageData, string elementName, string link) 
        {
            ID = id;
            ImageDataURL = imageData;
            ElementName = elementName;
            Link = link;
        }
        public PopularList() { }
    }
}
 