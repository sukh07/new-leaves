namespace Week04.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Week04Model : DbContext
    {
        public Week04Model()
            : base("name=Week04Model")
        {
        }

        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<Title> Titles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Title>()
                .Property(e => e.costPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Title>()
                .Property(e => e.retailPrice)
                .HasPrecision(19, 4);
        }
    }
}
