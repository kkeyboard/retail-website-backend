using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace web_app_1.Views.Account
{
    public class UserDetail : PageModel
    {
        private readonly ILogger<UserDetail> _logger;

        public UserDetail(ILogger<UserDetail> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}