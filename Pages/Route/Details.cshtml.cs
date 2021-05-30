﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BDTransportCompany.Data;
using BDTransportCompany.Models;

namespace BDTransportCompany.Pages.Route
{
    public class DetailsModel : PageModel
    {
        private readonly BDTransportCompany.Data.BDTransportCompanyContext _context;

        public DetailsModel(BDTransportCompany.Data.BDTransportCompanyContext context)
        {
            _context = context;
        }

        public Routes Routes { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Routes = await _context.Routes.FirstOrDefaultAsync(m => m.ID == id);

            if (Routes == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
