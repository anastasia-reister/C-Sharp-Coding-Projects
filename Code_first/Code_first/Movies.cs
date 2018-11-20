namespace Code_first
{
    using Code_first.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Movies : DbContext
    {
        // Your context has been configured to use a 'Movies' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Code_first.Movies' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Movies' 
        // connection string in the application configuration file.
        public Movies()
            : base("name=Movies")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Film> Films { get; set; }
        public virtual DbSet<Director> Directors { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}