using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SandboxOne.Models;

namespace SandboxOne.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public Person Person { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            Person = new Person();
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {

        }
    }
}
