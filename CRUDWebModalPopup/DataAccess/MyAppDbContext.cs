using CRUDWebModalPopup.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace CRUDWebModalPopup.DataAccess
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext(DbContextOptions options) : base(options)
        {

        }
        public virtual DbSet<Product> Products { get; set; }
    }
}
