using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace PricePredictor.Pages
{
    public class BMWModel : PageModel
    {
        private readonly ILogger<BMWModel> _logger;

        public BMWModel(ILogger<BMWModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
