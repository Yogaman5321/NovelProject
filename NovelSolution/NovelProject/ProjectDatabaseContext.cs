using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NovelProject.Models;

namespace NovelProject
{
    public class ProjectDatabaseContext : DbContext
    {
        // DbSet properties - these represent the tables in the database
        public DbSet<UserAccount> Users { get; set; }
        public DbSet<Novel> Novels { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<ReadHistory> ReadHistories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Configure the database connection string here
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=NovelProjectDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserAccount>(entity =>
            {
                entity.HasKey(u => u.UserId);
                entity.Property(u => u.Username).IsRequired().HasMaxLength(20);
                entity.Property(u => u.EncryptedPassword).IsRequired();
                entity.Property(u => u.AccountCreatedDate).IsRequired();
            });

            modelBuilder.Entity<Novel>(entity =>
            {
                entity.HasKey(n => n.NovelId);
                entity.Property(n => n.NovelName).IsRequired().HasMaxLength(100);
                entity.Property(n => n.AuthorName).IsRequired().HasMaxLength(50);
                // Might remove IsRequired for Description if we want to allow nulls
                entity.Property(n => n.Description).IsRequired().HasMaxLength(1000);
                entity.Property(n => n.DatePosted).IsRequired();

                entity.HasOne<UserAccount>()
                      .WithMany()
                      .HasForeignKey(n => n.UploadedByUserId)
                      .OnDelete(DeleteBehavior.ClientCascade);

                entity.HasMany<Tag>()
                      .WithMany()
                      .UsingEntity("NovelTags");
            });

            modelBuilder.Entity<Chapter>(entity =>
            {
                entity.HasKey(c => c.ChapterId);
                entity.Property(n => n.ChapterNumber).IsRequired();
                entity.Property(n => n.ChapterFilePath).IsRequired().HasMaxLength(200);
                entity.Property(c => c.DateAdded).IsRequired();

                entity.HasOne<Novel>()
                      .WithMany()
                      .HasForeignKey(c => c.NovelId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasIndex(c => new { c.NovelId, c.ChapterNumber }).IsUnique();
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.HasKey(r => r.ReviewId);
                entity.Property(r => r.ReviewContent).IsRequired().HasMaxLength(500);
                entity.Property(r => r.Rating).HasPrecision(3,2).IsRequired();
                entity.Property(r => r.ReviewPostedDate).IsRequired();

                entity.HasOne<UserAccount>()
                      .WithMany()
                      .HasForeignKey(r => r.UserId)
                      .OnDelete(DeleteBehavior.ClientCascade);

                entity.HasOne<Novel>()
                      .WithMany()
                      .HasForeignKey(r => r.NovelId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasIndex(r => new { r.UserId, r.NovelId }).IsUnique();
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.HasKey(c => c.CommentId);
                entity.Property(c => c.CommentString).IsRequired().HasMaxLength(500);
                entity.Property(c => c.DatePosted).IsRequired();

                entity.HasOne<UserAccount>()
                      .WithMany()
                      .HasForeignKey(c => c.UserId)
                      .OnDelete(DeleteBehavior.ClientCascade);

                entity.HasOne<Chapter>()
                      .WithMany()
                      .HasForeignKey(c => c.ChapterId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.HasKey(t => t.TagId);
                entity.Property(t => t.TagName).IsRequired().HasMaxLength(20);
                entity.Property(t => t.TagDescription).HasMaxLength(100);

                entity.HasIndex(t => t.TagName).IsUnique();
            });

            modelBuilder.Entity<ReadHistory>(entity =>
            {
                entity.HasKey(rh => new { rh.UserId, rh.ChapterId });
                entity.Property(rh => rh.LastReadDate).IsRequired();

                entity.HasOne<UserAccount>()
                      .WithMany()
                      .HasForeignKey(rh => rh.UserId)
                      .OnDelete(DeleteBehavior.ClientCascade);

                entity.HasOne<Chapter>()
                      .WithMany()
                      .HasForeignKey(rh => rh.ChapterId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

        }
    }
}
