#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ClaimsIdentity_zad_6.Data;
using ClaimsIdentity_zad_6.Models;

namespace ClaimsIdentity_zad_6.Pages.People
{
    public class DetailsModel : PageModel
    {
        private readonly ClaimsIdentity_zad_6.Data.ApplicationDbContext _context;

        public DetailsModel(ClaimsIdentity_zad_6.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Person Person { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Person = await _context.Person.FirstOrDefaultAsync(m => m.Id == id);

            if (Person == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
