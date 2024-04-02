using Microsoft.EntityFrameworkCore;
using MVC_crud.Models.Entities;

namespace MVC_crud.Data
{
    public class MVCDBContext : DbContext
    {
        public MVCDBContext(DbContextOptions<MVCDBContext> options) : base(options)
        {
        }

        public DbSet<Customers> Customers { get; set; }
    }
}
