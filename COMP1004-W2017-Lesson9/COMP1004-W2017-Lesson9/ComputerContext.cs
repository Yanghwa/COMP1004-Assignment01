namespace COMP1004_W2017_Lesson9
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ComputerContext : DbContext
    {
        public ComputerContext()
            : base("name=ComputerContextConnection")
        {
        }

        public virtual DbSet<product> products { get; set; } //Table in the DB

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<product>()
                .Property(e => e.cost)
                .HasPrecision(19, 4);
        }
    }
}
