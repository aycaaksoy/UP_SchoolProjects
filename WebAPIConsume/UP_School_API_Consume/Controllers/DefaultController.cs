using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace UP_School_API_Consume.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IHttpClientFactory httpClientFactory;

        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        public async Task <IActionResult> Index()
        {
            var client = httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44370/api/Category"); 
            if(responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                return View();
            }
            return View();
        }
    }
}
