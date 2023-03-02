using CRUD.Data;
using CRUD.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace CRUD.Pages.Users
{
    public class NewModel : PageModel
    {
        private readonly UserDbContext _context;
        public NewModel(UserDbContext context)=> _context = context;
        
        public void  OnPost()
        {  
            if (_context.User != null)
                {
                    _context.Add(User);
                    _context.SaveChanges();

                    RedirectToPage("../Index");
                }
            }
           
        


        [BindProperty]
        public User User { get; set; }
    }
}
