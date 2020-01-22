using System;
using System.Collections.Generic;
using System.Text;
using Bookshelf35.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bookshelf35.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Comment> Comment { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Create a new user for Identity Framework
            ApplicationUser user = new ApplicationUser
            {
                FirstName = "admin",
                LastName = "admin",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "00000000-ffff-ffff-ffff-ffffffffffff"
            };
            var passwordHash = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash.HashPassword(user, "Admin8*");
            modelBuilder.Entity<ApplicationUser>().HasData(user);

            //create Authors
            Author author1 = new Author
            {
                Id = 1,
                Name = "Jimmy John",
                ApplicationUserId = user.Id
            };
            modelBuilder.Entity<Author>().HasData(author1);

            Author author2 = new Author
            {
                Id = 2,
                Name = "Jersey Mike",
                ApplicationUserId = user.Id
            };
            modelBuilder.Entity<Author>().HasData(author2);

            Book jonBook = new Book
            {
                Id = 1,
                Title = "Free Smells",
                Genre = "Sammys",
                YearPublished = 1990,
                AuthorId = author1.Id,
                Rating = 10,
                ApplicationUserId = user.Id
            };
            modelBuilder.Entity<Book>().HasData(jonBook);

            Book wooBook = new Book
            {
                Id = 2,
                Title = "HeHaw the complete History",
                Genre = "Sammys",
                YearPublished = 1999,
                AuthorId = author2.Id,
                Rating = 1,
                ApplicationUserId = user.Id
            };
            modelBuilder.Entity<Book>().HasData(wooBook);
        }
    }

}
