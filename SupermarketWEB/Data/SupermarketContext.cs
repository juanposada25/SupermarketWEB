using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarkerEF.Data
{
    internal class SupermarketContext : DbContext
    {

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }



    }
}
