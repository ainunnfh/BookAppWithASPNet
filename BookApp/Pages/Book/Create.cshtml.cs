using BookApp.Data;
using BookApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookApp.Pages.Book
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext context;

        public CreateModel(AppDbContext context)
        {
            this.context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Books Books { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            context.Books.Add(Books);
            await context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
