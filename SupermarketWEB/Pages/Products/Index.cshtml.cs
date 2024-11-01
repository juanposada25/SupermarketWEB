using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarkerEF.Data;
using SupermarketWEB.Models;

namespace SupermarketWEB.Pages.Products
    {
        public class IndexModel : PageModel
        {
            private readonly SupermarketContext _context;

            public IndexModel(SupermarketContext context)
            {
                _context = context;
            }

            public IList<Product> Products { get; set; } = default!;

            public async Task OnGetAsync()
            {
                Products = await _context.Products
                    .Include(p => p.Category) 
                    .ToListAsync();
            }
        }
    }

