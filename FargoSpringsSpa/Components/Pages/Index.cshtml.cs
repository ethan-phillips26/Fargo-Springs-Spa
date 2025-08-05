using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FargoSpringsSpa.Data;
using FargoSpringsSpa.Models;

namespace FargoSpringsSpa.Components.Pages
{
    public class IndexModel : PageModel
    {
        private readonly FargoSpringsSpa.Data.FargoSpringsSpaContext _context;

        public IndexModel(FargoSpringsSpa.Data.FargoSpringsSpaContext context)
        {
            _context = context;
        }

        public IList<Booking> Booking { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Booking = await _context.Booking
                .Include(b => b.Service)
                .Include(b => b.User).ToListAsync();
        }
    }
}
