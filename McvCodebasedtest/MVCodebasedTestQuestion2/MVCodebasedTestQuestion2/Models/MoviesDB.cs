using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace MVCodebasedTestQuestion2.Models
{
        public class MoviesDB : DbContext
        {
            public MoviesDB() : base("MoviesDB")

            {

            }
            public DbSet<Movies> Movie { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movies>()
                .Property(e => e.Moviename)
                .IsUnicode(false);
        }
    }
}