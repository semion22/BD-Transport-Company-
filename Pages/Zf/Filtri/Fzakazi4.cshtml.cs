using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BDTransportCompany.Data;
using BDTransportCompany.Models;
using System.Collections.Generic;
using System.Linq;

namespace BDTransportCompany.Pages.Zf.Filtri
{
    public class Fzakazi4 : PageModel
    {
        private readonly BDTransportCompany.Data.BDTransportCompanyContext _context;

        public Fzakazi4(BDTransportCompany.Data.BDTransportCompanyContext context)
        {
            _context = context;
        }

        public IList<Routes> Routes { get; set; }
        public Routes Route { get; set; }

        public async Task<IActionResult> OnGetAsync(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Route = await _context.Routes.FirstOrDefaultAsync(m => m.TheMarkOnTheReturn == id);

            if (Route == null)
            {
                return NotFound();
            }
            Routes = await _context.Routes.Where(m => m.TheMarkOnTheReturn == Route.TheMarkOnTheReturn).ToListAsync();
            return Page();
        }
    }
}

