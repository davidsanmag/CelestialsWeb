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


namespace RetoTernium.Pages
{
    public class HomeModel : PageModel
    {
        [BindProperty]
        public string HomeBody { get; set; }

        public string UsernameHome { get; set; }

        public void OnGet(string result)
        {
            HomeBody = result;
            UsernameHome = HttpContext.Session.GetString("username");
        }
    }
}
