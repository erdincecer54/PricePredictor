using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace PricePredictor.Pages
{
    public class VWModel : PageModel
    {
        private readonly ILogger<VWModel> _logger;

        public VWModel(ILogger<VWModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
