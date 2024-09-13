using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace ASPlab3.Pages
{
    public class TimeModel : PageModel
    {
        private readonly ILogger<TimeModel> _logger;

        public TimeModel(ILogger<TimeModel> logger)
        {
            _logger = logger;
        }

        public string Message { get; set; } = string.Empty;
        public List<int> LuckyNumbers { get; set; } = new List<int>();

        public void OnGet()
        {
            Message = "Here are your lucky numbers! The sum of your lucky numbers equal the number of seconds until Time Warp begins:";
            LuckyNumbers = new List<int> { 7, 13, 21, 42 };

          
            _logger.LogCritical("Critical Message, Time Warp beginning soon.");
        }
    }
}

