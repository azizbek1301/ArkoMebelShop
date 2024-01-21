using ArkoMebel.Domain.Entites;
using Microsoft.EntityFrameworkCore;

namespace ArkoMebel.Service.Abstraction.DataAccess
{
    public interface IApplicationDbContext
    {
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

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
