using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Турнирная_сетка.Data;
using Турнирная_сетка.Entities;

namespace Турнирная_сетка.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public Tournament? Tournament { get; set; }

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int tournamentId)
        {
            var tournament = await _context.Tournaments
    .Include(t => t.Teams)
    .Include(t => t.Rounds)
        .ThenInclude(r => r.Matches)
            .ThenInclude(m => m.Team1)
    .Include(t => t.Rounds)
        .ThenInclude(r => r.Matches)
            .ThenInclude(m => m.Team2)
    .FirstOrDefaultAsync(t => t.Id == tournamentId);

            //        var tournament = await _context.Tournaments
            //.FirstOrDefaultAsync(t => t.Id == 1);








            if (tournament == null)
            {
                throw new Exception("Турнир не найден.");
            }

            return Page();
        }

    }
}
