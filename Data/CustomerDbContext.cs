using Microsoft.EntityFrameworkCore;
using RazorPagesInMemory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesInMemory.Data
{
    // it is bridge which coonect your razor application to the DB
    // DB context class simply coonnect your data information to the DB
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions options): base(options)
        {

        }
        // DBSet job -->
        // convert model class (Customer) into dataTable (Customer) 
        // convert your model class into database scheme table
        public DbSet<Customer> Customers { get; set; }
    }
}

// why we call it Razor Pages ?
//  Client pages --> HTML tags ( client side code)
// Razor Page --> Clinet side + server side = Razor Pages
