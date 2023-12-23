
using System.Threading.Tasks;
using First_semestrovka_test.Attributes;
using Oris_First_Semestrovka.Attributes;
using MyORM;


namespace First_semestrovka_test.Controllers
{
    [Controller("StoreInfo")]
    public class StoreInfoController
    {
        [Post("StoreInfoInDataBase")]
        public void StoreInfoInDataBase(string text, string elementID, string imageData)
        {
            try
            {
                Console.WriteLine($"text:{text}");
                text = text[1..];
                elementID = elementID[1..];
                imageData = imageData[1..];
                Console.WriteLine("Данные нового абзаца получены");
                new Database("Data Source=localhost;Initial Catalog=Oris_First_Semestrovka;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;" +
                                    "Application Intent=ReadWrite;Multi Subnet Failover=False").Insert(new UserData(text, elementID, imageData));
                Console.WriteLine("Данные нового абзаца успешно сохранены в базу данных"); 

            }
            catch (Exception ex) 
            { 
                Console.WriteLine("Не удалось сохранить данные нового абзаца в базу данных"); 
            }
        }

        [Get("GetInfoFromDataBase")]
        public List<UserData> GetInfoFromDataBase()
        {
            Console.WriteLine("Отправляем данные клиенту");
            var userDataList = new Database("Data Source=localhost;Initial Catalog=Oris_First_Semestrovka;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;" +
                                    "Application Intent=ReadWrite;Multi Subnet Failover=False").Select<UserData>().ToList();
            return userDataList;
        }
    }
}
