using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Tracking.Data;
using Tracking.Models;

namespace Tracking.Pages.Shared.Issues
{
    public class NewModel : PageModel
    {
        private readonly IssueDbContext _context;
        public NewModel(IssueDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult>  OnPost()
        {
            Issues.Created = DateTime.Now;
            await _context.AddAsync(Issues);
            await _context.SaveChangesAsync();

            return RedirectToPage("Index");

        }

        public Issue Issues { get; set; }
    }
}
