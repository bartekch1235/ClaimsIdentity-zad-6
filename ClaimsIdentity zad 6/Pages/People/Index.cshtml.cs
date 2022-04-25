#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ClaimsIdentity_zad_6.Data;
using Microsoft.AspNetCore.Authorization;
using ClaimsIdentity_zad_6.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNet.Identity;

namespace ClaimsIdentity_zad_6.Pages.People
{   [Authorize]
    public class IndexModel : PageModel
    {
        private readonly Microsoft.AspNetCore.Identity.UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;





        private readonly ClaimsIdentity_zad_6.Data.ApplicationDbContext _context;

        public IndexModel(ClaimsIdentity_zad_6.Data.ApplicationDbContext context, Microsoft.AspNetCore.Identity.UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IList<Person> Person { get;set; }

        public async Task OnGetAsync()
        {
            Person = await _context.Person.ToListAsync();
            var user = _userManager.GetUserName(User);
            ViewData["email"] = user.ToString();
        }
    }
}
