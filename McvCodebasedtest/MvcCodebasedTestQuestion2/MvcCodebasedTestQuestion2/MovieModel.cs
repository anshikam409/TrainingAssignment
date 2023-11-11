using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MVCCodebasedTestQuestion2
{
    public partial class MovieModel : DbContext
    {
        public MovieModel()
            : base("name=MovieModel")
        {
        }

        public virtual DbSet<Movy> Movies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movy>()
                .Property(e => e.Moviename)
                .IsUnicode(false);

            modelBuilder.Entity<Movy>()
                .Property(e => e.MovieType)
                .IsUnicode(false);
        }
    }
}
