using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace PricePredictor.Pages
{
    public class HyundaiModel : PageModel
    {
        private readonly ILogger<HyundaiModel> _logger;

        public HyundaiModel(ILogger<HyundaiModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
