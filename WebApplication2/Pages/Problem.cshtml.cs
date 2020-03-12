using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1._17bang;
using ConsoleApp1.Repoistories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplicationCore.Pages
{
    public class ProblemModel : PageModel
    {
        public IList<Problem> Problems { get; set; }

        public void OnGet()
        {
            ProblemRepoistory problemRepoistory = new ProblemRepoistory();
            Problems = problemRepoistory.GetProblems();
            
        }
    }
    
}
