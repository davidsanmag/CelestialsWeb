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
using System.Data;

namespace RetoTernium.Pages
{
    public class LeaderboardModel : PageModel
    {
        [BindProperty]
        public List<Scores> listScores { get; set; }

        public async Task OnGetAsync(string result)
        {

            string responseContent = "[]";
            string URL = $"https://chatarrap-api.herokuapp.com/attempts/scoresPast";

            //Buscamos el recurso
            Uri baseURL = new Uri(URL);

            //Creamos el cliente para que haga nuestra peticion
            HttpClient client = new HttpClient();
            string token = HttpContext.Session.GetString("token");
            client.DefaultRequestHeaders.Add("auth_key", token);
            HttpResponseMessage response = await client.GetAsync(baseURL.ToString());

            responseContent = await response.Content.ReadAsStringAsync();
            listScores = JsonConvert.DeserializeObject<List<Scores>>(responseContent);


        }
    }
}
