using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace PricePredictor.Pages
{
    public class AudiModel : PageModel
    {
        private readonly ILogger<AudiModel> _logger;

        public AudiModel(ILogger<AudiModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
