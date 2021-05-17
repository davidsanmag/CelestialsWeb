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

        public async Task OnGetAsync(string result)
        {
            HomeBody = result;
            UsernameHome = HttpContext.Session.GetString("username");

            string responseContent = "[]";
            //string URL = $"https://chatarrap-api.herokuapp.com/users/{UsernameHome}";
            string URL = $"https://chatarrap-api.herokuapp.com/users/5fa5f0726061085300019117";
            //Buscamos el recurso
            Uri baseURL = new Uri(URL);

            //Creamos el cliente para que haga nuestra peticion
            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(baseURL.ToString());

            responseContent = await response.Content.ReadAsStringAsync();
            GetTest = responseContent;

        }

    }
}
