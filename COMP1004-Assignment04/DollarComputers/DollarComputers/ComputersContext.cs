//FileName: ComputersContext.cs
//FileType: Visual C# Source file
//Author: Junghwan Yang
//Student ID: 200320739
//Created On: 07/03/2017
//Copy Rights: Junghwan Yang
//Description: This app uses Entity framework and connects to db 
//  

/////////////////////////////////////////////////////////////////////////


namespace DollarComputers
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ComputersContext : DbContext
    {
        public ComputersContext()
            : base("name=ComputersContextConnection")
        {
        }

        public virtual DbSet<Product> products { get; set; } //Table in the DB

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(e => e.cost)
                .HasPrecision(19, 4);
        }
    }
}
