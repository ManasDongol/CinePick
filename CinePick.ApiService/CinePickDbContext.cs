using CinePick.ApiService.Entites;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using CinePick.ApiService.Entites;

namespace CinePick.ApiService
{
    public class CinePickDbContext : IdentityDbContext<ApplicationUsers, IdentityRole<Guid>, Guid>
    {
        public CinePickDbContext(DbContextOptions<CinePickDbContext> options)
            : base(options)
        {
        }

        public DbSet<Genres> Genres { get; set; }
        public DbSet<Movies> Movies { get; set; }
        public DbSet<UserMovieInteraction> UserMovieInteractions { get; set; }
        public DbSet<WatchList> WatchLists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUsers>().ToTable("users");
            modelBuilder.Entity<Movies>().ToTable("movies");
            modelBuilder.Entity<Genres>().ToTable("genres");
            modelBuilder.Entity<UserMovieInteraction>().ToTable("user_movie_interactions");
            modelBuilder.Entity<WatchList>().ToTable("watchlists");
        }
    }
}