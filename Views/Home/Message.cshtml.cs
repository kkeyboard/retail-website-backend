using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace web_app_1.Views.Home
{
    public class Message : PageModel
    {
        private readonly ILogger<Message> _logger;

        public Message(ILogger<Message> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}