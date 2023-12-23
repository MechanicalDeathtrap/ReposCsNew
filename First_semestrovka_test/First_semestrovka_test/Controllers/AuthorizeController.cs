using First_semestrovka_test.Attributes;
using First_semestrovka_test.Services;
using Microsoft.AspNetCore.Http;
using MyORM;
using Oris_First_Semestrovka.Attributes;

namespace Oris_First_Semestrovka.Controllers
{
    [Controller("Authorize")]
    public class AuthorizeController
    {
        [Post("AuthorizeAdmin")]

        public string[] AuthorizeAdmin(string name, string login, string password)
        {
            Console.WriteLine("Зашли в метод AuthorizeAdmin");
            var newlogin = login.Substring(0, 5) + "@" + login.Substring(8);
            var isAuthorized = new UserAuthorization().Authorization(name, newlogin, password);

            var result = new string[2];

            if (isAuthorized)
            {
                result[0] = "/static/index1_admin.html";
                result[1] = "200";

                return result;
            }
            result[0] = "/static/index_authorization.html";
            result[1] = "403";

            return result;
        }

        [Get("IsAuthorized")]
        public string IsAuthorized()
        {
            
            return "/static/404.html";
        }
    }
}
