using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace web_app_1.Views
{
    public class Success : PageModel
    {
        private readonly ILogger<Success> _logger;

        public Success(ILogger<Success> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}