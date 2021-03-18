using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RazorPagesInMemory.Data;
using RazorPagesInMemory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesInMemory.Pages
{
    public class IndexModel : PageModel
    {
        public IList<Customer> ListCustomers { get; set; }

        private readonly CustomerDbContext _dbContext;
        public IndexModel(CustomerDbContext dbContext)
        {
            _dbContext = dbContext;
        }
       
       
        public void OnGet()
        {
            ListCustomers = _dbContext.Customers.ToList();            
        }
    }
}
