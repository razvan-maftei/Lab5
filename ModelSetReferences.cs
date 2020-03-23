using System.Collections.Generic;

namespace Laborator5
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelSetReferences : DbContext
    {
        // Your context has been configured to use a 'ModelSetReferences' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Laborator5.ModelSetReferences' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ModelSetReferences' 
        // connection string in the application configuration file.
        public ModelSetReferences()
            : base("name=ModelSetReferences")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<SelfReference> SelfReferences { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SelfReference>()
                .HasMany(m => m.References)
                .WithOptional(m => m.ParentSelfReference);
        }
    }
}