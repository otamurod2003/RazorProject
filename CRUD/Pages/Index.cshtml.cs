using CRUD.Data;
using CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Pages
{
    public class IndexModel : PageModel
    {
       private readonly UserDbContext _context;
        public IndexModel(UserDbContext context)=> _context= context;
        
        public async void OnGet()
        {
            Users  = await _context.User.Where(i => i.Id != null)
               .OrderByDescending(i => i.Name)
               .ToListAsync();
        }

        public IEnumerable<User> Issues { get; set; } = Enumerable.Empty<User>();
        public List<User> Users { get; private set; }
    }
}