using _2526_2221050573_BaiThi.Controllers;
using _2526_2221050573_BaiThi.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace _2526_2221050573_BaiThi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
       
    }
}