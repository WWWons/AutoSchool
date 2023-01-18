
using AutoSchool.Domain.Enum;
using AutoSchool.Domain.Entity;
using AutoSchool.Domain.Helpers;
using Microsoft.EntityFrameworkCore;

namespace AutoSchool.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
    public DbSet<User> Users { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(builder =>
        {
            builder.ToTable("Users").HasKey(x => x.Id);

            builder.HasData(new User
            {
                Id = 2,
                Name = "admin",
                Password = HashPasswordHelper.HashPassowrd("123456"),
                Role = Role.Admin
            });

            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Password).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(100).IsRequired();

       

            
        });
       
    }
}
