using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesInMemory.Model
{
    public class Customer
    {
        // Data validation : we want validate our fields
        public int Id { get; set; }

        // attributes
        [Required, StringLength(20)]
        public string Name { get; set; }
    }
}
