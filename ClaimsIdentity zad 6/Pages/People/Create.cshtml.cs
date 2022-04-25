#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ClaimsIdentity_zad_6.Data;
using ClaimsIdentity_zad_6.Models;
using Microsoft.AspNetCore.Identity;

namespace ClaimsIdentity_zad_6.Pages.People
{
    public class CreateModel : PageModel
    {
        private readonly ClaimsIdentity_zad_6.Data.ApplicationDbContext _context;
        private readonly Microsoft.AspNetCore.Identity.UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public CreateModel(ClaimsIdentity_zad_6.Data.ApplicationDbContext context, Microsoft.AspNetCore.Identity.UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult OnGet()
        {
            var user = _userManager.GetUserName(User);
            
            return Page();

        }

        [BindProperty]
        public Person Person { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            Person.email = _userManager.GetUserName(User);
            if (Person.FirstName == null||Person.LastName == null)
            {
                return Page();
            }

            _context.Person.Add(Person);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
