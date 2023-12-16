using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Q2.Model;

namespace Q2.Data
{
    public class Q2Context : DbContext
    {
        public Q2Context (DbContextOptions<Q2Context> options)
            : base(options)
        {
        }

        public DbSet<Q2.Model.Students> Students { get; set; } = default!;

        public DbSet<Q2.Model.Courses>? Courses { get; set; }
    }
}
