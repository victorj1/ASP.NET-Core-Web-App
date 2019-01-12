using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyCar.Models
{
    public class MyCarContext : DbContext
    {
        public MyCarContext (DbContextOptions<MyCarContext> options)
            : base(options)
        {
        }

        public DbSet<MyCar.Models.Car> Car { get; set; }
    }
}
