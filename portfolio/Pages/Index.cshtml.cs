using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using portfolio.API;
using Microsoft.AspNetCore.Mvc.Razor;
using portfolio.API.data;

namespace portfolio.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        Portfolio portfolio;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            portfolio = new Portfolio();
        }

        public void OnGet()
        {
        }

        public Portfolio? GetData()
        {
            return portfolio;
        }

    }
}
