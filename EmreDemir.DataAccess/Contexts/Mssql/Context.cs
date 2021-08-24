using EmreDemir.Entities.Concrete;
using EmreDemir.Entities.Conrete;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmreDemir.DataAccess.Contexts.PostgreSql
{
    public class Context : DbContext
    {
        public DbSet<PostCard> postCards { get; set; }
        public DbSet<WhoAmI> WhoAmI { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(@"cs");
    }
}



