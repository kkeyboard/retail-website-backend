using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace web_app_1.Views.Customer
{
    public class Method1 : PageModel
    {
        private readonly ILogger<Method1> _logger;

        public Method1(ILogger<Method1> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}