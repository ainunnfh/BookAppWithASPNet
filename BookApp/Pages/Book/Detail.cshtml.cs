using BookApp.Data;
using BookApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookApp.Pages.Book
{
    public class DetailModel : PageModel
    {
        private readonly AppDbContext context;

        public DetailModel(AppDbContext context)
        {
            this.context = context;
        }

        public Books Books { get; set; } = default;


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if(id == null)
            {
                return RedirectToPage("./Index");
            }
            var books = await context.Books.FirstOrDefaultAsync(e => e.Id == id);
            if (books == null)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                Books = books;
                return Page();
            }
        }
    }
}
