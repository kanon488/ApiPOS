using Microsoft.EntityFrameworkCore;

namespace ApiPOS.AppCode.DBContext
{
    public partial class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base (options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
