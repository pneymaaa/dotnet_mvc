using dotnet_mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_mvc.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {          
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<udt_Personal>(entity =>
            {
                entity.HasNoKey();
                entity.Property(o => o.Name).HasColumnType("varchar(25)");
                entity.Property(o => o.IdHobby).HasColumnType("char(1)");
                entity.Property(o => o.NameHobby).HasColumnType("varchar(50)");
                entity.Property(o => o.GenderName).HasColumnType("varchar(10)");
            });
            modelBuilder.Entity<tblM_Gender>(entity =>
            {
                entity.Property(o => o.Name).HasColumnType("varchar(10)");
                entity.Property(o => o.Id).HasColumnType("int");
            });
            modelBuilder.Entity<tblM_Hobby>(entity =>
            {
                entity.Property(o => o.Name).HasColumnType("varchar(50)");
                entity.Property(o => o.Id).HasColumnType("char(1)");
            });
            modelBuilder.Entity<tblT_Age>(entity =>
            {
                entity.Property(o => o.Age).HasColumnType("int");
                entity.Property(o => o.Total).HasColumnType("int");
            });
            base.OnModelCreating(modelBuilder);
        }

        //Entities
        public DbSet<tblM_Gender> tblM_Genders { get; set; }
        public DbSet<tblM_Hobby> tblM_Hobbies { get; set; }
        public DbSet<tblT_Age> tblT_Ages { get; set; }
        public DbSet<tblT_Personal> tblT_Personals { get; set; }

        //public DbSet<udt_Personal> udt_Personals { get; set; }
    }
}