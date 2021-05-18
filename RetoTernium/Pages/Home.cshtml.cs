using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RetoTernium.Model;
using System.Web;
using System.Net.Http;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Text;
using System.Net.Http.Headers;


namespace RetoTernium.Pages
{
    public class HomeModel : PageModel
    {
        [BindProperty]
        public string HomeBody { get; set; }

        [BindProperty]
        public string UsernameHome { get; set; }

        [BindProperty]
        public string GetTest { get; set; }

        [BindProperty]
        public User user { get; set; }

        public IList<string> usertype { get; set; }
        public string _id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int streak { get; set; }
        public string scores { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }

        public async Task OnGetAsync(string result)
        {
            HomeBody = result;
            UsernameHome = HttpContext.Session.GetString("user");

            string responseContent = "[]";
            string URL = $"https://chatarrap-api.herokuapp.com/users/{UsernameHome}";
            //string URL = $"https://chatarrap-api.herokuapp.com/users/5fa5f0726061085300019117";
            //Buscamos el recurso
            Uri baseURL = new Uri(URL);

            //Creamos el cliente para que haga nuestra peticion
            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(baseURL.ToString());

            responseContent = await response.Content.ReadAsStringAsync();
            user = JsonConvert.DeserializeObject<User>(responseContent);
            username = user.username;
            streak = user.streak;
            scores = user.scores;
            createdAt = user.createdAt;
            updatedAt = user.updatedAt;


        }

    }
}
