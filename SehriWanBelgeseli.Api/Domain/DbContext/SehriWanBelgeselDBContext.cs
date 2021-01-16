using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SehriWanBelgeseli.Api.Domain
{
    public partial class SehriWanBelgeselDBContext : DbContext
    {
        public SehriWanBelgeselDBContext()
        {
        }

        public SehriWanBelgeselDBContext(DbContextOptions<SehriWanBelgeselDBContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
