using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace web_app_1.Views.Account
{
    public class UserList : PageModel
    {
        private readonly ILogger<UserList> _logger;

        public UserList(ILogger<UserList> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}