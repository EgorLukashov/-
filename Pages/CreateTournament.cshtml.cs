using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using Турнирная_сетка.Data;
using Турнирная_сетка.Entities;

namespace Турнирная_сетка.Pages
{
    public class CreateTournamentModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateTournamentModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Tournament Tournament { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Tournaments.Add(Tournament);
            await _context.SaveChangesAsync();

            return RedirectToPage("Index", new { tournamentId = Tournament.Id });
        }
    }
}
