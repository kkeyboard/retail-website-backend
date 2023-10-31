using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace web_app_1.Views.Customer
{
    public class QueryTest : PageModel
    {
        private readonly ILogger<QueryTest> _logger;

        public QueryTest(ILogger<QueryTest> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}