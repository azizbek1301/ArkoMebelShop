using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace ArkoMebel.Infrastructure.Peristance
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.Migrate();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("USER ID = postgres; Password=root;Ssrver=localhost;Port=5432;Database=ArkoMebelDb;Integrated Security = true;Pooling = true;", builder =>
            {
                builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
            });
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Box> Boxes { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Likes> Likes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Portfolio> Portfolio { get; set; }
        public DbSet<Prodact_Box> Prodact_Boxes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }


    }

}
