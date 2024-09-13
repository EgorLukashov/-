using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using Турнирная_сетка.Data;
using Турнирная_сетка.Entities;

namespace Турнирная_сетка.Pages
{
    public class ManageTeamsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ManageTeamsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Team Team { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return Page();
            }

            Team = await _context.Teams.FindAsync(id);

            if (Team == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (Team.Id == 0)
            {
                _context.Teams.Add(Team);
            }
            else
            {
                _context.Teams.Update(Team);
            }

            await _context.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
