using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace web_app_1.Views
{
    public class Method2 : PageModel
    {
        private readonly ILogger<Method2> _logger;

        public Method2(ILogger<Method2> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}