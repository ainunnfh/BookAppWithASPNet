using BookApp.Data;
using BookApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace BookApp.Pages.Book
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext context;

        public IndexModel(AppDbContext context)
        {
            this.context = context;
        }

        public IList<Books> Books { get; set; } = default;

        public async Task OnGetAsync()
        {
            Books = await context.Books.ToListAsync();
        }
    }
}
