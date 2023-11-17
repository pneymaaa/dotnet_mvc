using dotnet_mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_mvc.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {          
        }

        //Entities
        public DbSet<tblM_Gender> tblM_Genders { get; set; }
        public DbSet<tblM_Hobby> tblM_Hobbies { get; set; }
        public DbSet<tblT_Age> tblT_Ages { get; set; }
        public DbSet<tblT_Personal> tblT_Personals { get; set; }
    }
}