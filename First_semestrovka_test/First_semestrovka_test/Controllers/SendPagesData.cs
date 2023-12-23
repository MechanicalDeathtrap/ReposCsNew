using First_semestrovka_test.Attributes;
using MyORM;
using Oris_First_Semestrovka.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_semestrovka_test.Controllers
{
    [Controller("SendData")]
    public class SendPagesData
    {
        [Get("SendListToClient")]
        public List<PopularList> SendListToClient()
        {
            try
            {
                var list = new Database("Data Source=localhost;Initial Catalog=Oris_First_Semestrovka;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;" +
                                    "Application Intent=ReadWrite;Multi Subnet Failover=False").Select<PopularList>().ToList();
                Console.WriteLine($"send list method: {list.Count}");
                return list;
            }
            catch 
            {
                Console.WriteLine("Не удалось отправить данные списка клиенту");
                return null;
            }
        }
    }
}
