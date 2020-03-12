using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplicationCore.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            ViewData["time"] = DateTime.Now;
        }
        public void OnPost()
        {

        }
    }
}
