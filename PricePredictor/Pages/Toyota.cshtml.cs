using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace PricePredictor.Pages
{
    public class ToyotaModel : PageModel
    {
        private readonly ILogger<ToyotaModel> _logger;

        public ToyotaModel(ILogger<ToyotaModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
