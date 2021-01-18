using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace PricePredictor.Pages
{
    public class VauxhallModel : PageModel
    {
        private readonly ILogger<VauxhallModel> _logger;

        public VauxhallModel(ILogger<VauxhallModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
