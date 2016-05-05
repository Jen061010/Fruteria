using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure;

namespace Infrastructure
{
    public partial class AppContext:DbContext,IDbContextProduct,IDbContextTicket
    {
        public AppContext():base("DefaultConnection")
        {
            var cn = this.Database.Connection.ConnectionString;
        }
        public IDbSet<Product> Product { get; set; }
        public IDbSet<Ticket> Ticket { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
