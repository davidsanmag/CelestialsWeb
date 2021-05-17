using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using RetoTernium.Model;
using System.Web;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Text;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;

namespace RetoTernium.Pages
{
    public class IndexModel : PageModel
    {
        /*[BindProperty]
        public string username { get; set; }
        */

        [BindProperty]
        public Login Usuario { get; set; }

        [BindProperty]
        public Logged logged { get; set; }

        [BindProperty]
        public string Mensaje { get; set; }

        public async Task<IActionResult> OnPost()
        {
            string responseContent = "[]";

            //Buscamos el recurso
            Uri baseURL = new Uri("https://chatarrap-api.herokuapp.com/users/login");

            //Creamos el cliente para que haga nuestra peticion
            HttpClient client = new HttpClient();

            // Armamos nuestra peticion
            JObject joPeticion = new JObject();
            joPeticion.Add("username", Usuario.username);
            joPeticion.Add("password", Usuario.password);

            var stringContent = new StringContent(joPeticion.ToString(), Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(baseURL.ToString(), stringContent);

            if (response.IsSuccessStatusCode)
            {
                responseContent = await response.Content.ReadAsStringAsync();
                logged = JsonConvert.DeserializeObject<Logged>(responseContent);

                string connectionString = "Server=127.0.0.1;Port=3306;Database=terniumbd;Uid=root;password=celestials;";
                MySqlConnection conexion = new MySqlConnection(connectionString);
                conexion.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "INSERT INTO `terniumbd`.`registros` (`username`,`fecha`) VALUES (@username,now());";

                cmd.Parameters.AddWithValue("username", Usuario.username);
                cmd.ExecuteNonQuery();

                conexion.Dispose();

                HttpContext.Session.SetString("username", Usuario.username);
            }

            //SET HEADERS
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("auth_key", logged.token);


            return RedirectToPage("Home", new { result = logged.user });
        }


        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

    }
}
