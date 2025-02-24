using BookApp.Data;
using BookApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookApp.Pages.Book
{
    public class EditModel : PageModel
    {
        private readonly AppDbContext context;

        public EditModel(AppDbContext context)
        {
            this.context = context;
        }
        [BindProperty]
        public Books Books { get; set; } = default;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            
             if (id == null )
            {
                return RedirectToPage("./Index");
            }
             var books = await context.Books.FirstOrDefaultAsync(e => e.Id == id);
                if(books == null)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                Books = books;
                return Page();
            }
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            context.Books.Update(Books);
            await context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
