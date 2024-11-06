using SupermarketWEB.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using SupermarketWEB.Data;

namespace SupermarketWEB.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private readonly SupermarketContext _context;

        public RegisterModel(SupermarketContext context)
        {
            _context = context;
        }

        [BindProperty]
        public User User { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

            var existingUser = _context.Users
                .FirstOrDefault(u => u.Email == User.Email);

            if (existingUser != null)
            {
                ModelState.AddModelError(string.Empty, "El correo ya está registrado.");
                return Page();
            }


            _context.Users.Add(User);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Account/Login");
        }
    }
}
