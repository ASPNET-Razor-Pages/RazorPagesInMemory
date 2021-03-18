using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesInMemory.Data;
using RazorPagesInMemory.Model;

namespace RazorPagesInMemory.Pages
{
    public class CreateModel : PageModel
    {
        // How we inject our services (customerDbContext) via dependency Injection
        private readonly CustomerDbContext _dbContext;
        public CreateModel(CustomerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [BindProperty]
        public Customer Customer { get; set; }
        public IActionResult OnGet()
        {
            return Page();
            // bydefault this method builtin when the page is created
        }

        // This method we define for use or call Post Method 
        public async Task<IActionResult> OnPostAsync()
        {
            // always validate your data field ( Id and Name)
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            // save into the db context reference
            _dbContext.Customers.Add(Customer);
            // save also in DB
            await _dbContext.SaveChangesAsync();
            // . represent the main root of folder (Pages)
            return RedirectToPage("./Index");
        }

    }
}
