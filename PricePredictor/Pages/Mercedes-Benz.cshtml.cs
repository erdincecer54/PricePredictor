using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace PricePredictor.Pages
{
    public class BenzModel : PageModel
    {
        private readonly ILogger<BenzModel> _logger;

        public BenzModel(ILogger<BenzModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
