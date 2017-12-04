using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MinhasCompras.Models;

namespace MinhasCompras.Models
{
    public class MVCContext : DbContext
    {
        public MVCContext (DbContextOptions<MVCContext> options) : base(options)
        {

        }        

        public DbSet<MinhasCompras.Models.Item> Item { get; set; }
    }
}
