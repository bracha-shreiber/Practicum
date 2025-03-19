using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using Resume.Core.Models;
using Match = Resume.Core.Models.Match;
namespace Resume.Data
{
    public class ResumeContext : DbContext
    {
        public ResumeContext(DbContextOptions<ResumeContext> options) : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<ResumeFile> ResumeFiles { get; set; }
        public virtual DbSet<Sharing> Sharings { get; set; }
        public virtual DbSet<Match> Matches { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Shiduchim");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Match>()
               .HasKey(m => m.MatchID);

            modelBuilder.Entity<Match>()
                .HasOne(m => m.Resumefile1)
                .WithMany() // No navigation property in ResumeFile for Matches
                .HasForeignKey(m => m.ResumefileID1)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascading delete

            modelBuilder.Entity<Match>()
                .HasOne(m => m.Resumefile2)
                .WithMany() // No navigation property in ResumeFile for Matches
                .HasForeignKey(m => m.ResumefileID2)
                .OnDelete(DeleteBehavior.Restrict); 
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //        // Configuring User entity
        //    //        modelBuilder.Entity<User>()
        //    //            .HasKey(u => u.UserID);

        //    //        //modelBuilder.Entity<User>()
        //    //        //    .HasMany(u => u.Files)
        //    //        //    .WithOne(r => r.User)
        //    //        //    .HasForeignKey(r => r.UserID);

        //    //        // Configuring ResumeFile entity
        //    //        modelBuilder.Entity<ResumeFile>()
        //    //            .HasKey(r => r.ResumeFileID);

        //    //        //modelBuilder.Entity<ResumeFile>()
        //    //        //    .HasOne<User>()
        //    //        //    .WithMany(u => u.Files)
        //    //        //    .HasForeignKey(r => r.UserID);

        //    //        // Configuring Sharing entity
        //    //        modelBuilder.Entity<Sharing>()
        //    //            .HasKey(s => s.ShareID);

        //    //        modelBuilder.Entity<Sharing>()
        //    //            .HasOne(s => s.Resumefile)
        //    //            .WithMany()
        //    //            .HasForeignKey(s => s.ResumefileID);

        //    //        // Configuring Match entity
        //    //        modelBuilder.Entity<Match>()
        //    //            .HasKey(m => m.MatchID);

        //    //        //modelBuilder.Entity<Match>()
        //    //        //    .HasOne(m => m.Resumefile1)
        //    //        //    .WithMany()
        //    //        //    .HasForeignKey(m => m.ResumefileID1);

        //    //        //modelBuilder.Entity<Match>()
        //    //        //    .HasOne(m => m.Resumefile2)
        //    //        //    .WithMany()
        //    //        //    .HasForeignKey(m => m.ResumefileID2);
        //    //        modelBuilder.Entity<Match>()
        //    //.HasOne(m => m.Resumefile1)
        //    //.WithMany()
        //    //.HasForeignKey(m => m.ResumefileID1)
        //    //.OnDelete(DeleteBehavior.Restrict); // או DeleteBehavior.NoAction

        //    //        modelBuilder.Entity<Match>()
        //    //            .HasOne(m => m.Resumefile2)
        //    //            .WithMany()
        //    //            .HasForeignKey(m => m.ResumefileID2)
        //    //            .OnDelete(DeleteBehavior.Restrict); // או DeleteBehavior.NoAction

        //    //    }

        //    //    //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //    //    //{
        //    //    //    modelBuilder.Entity<Match>()
        //    //    //        .HasOne(m => m.Resumefile1)
        //    //    //        .WithMany()
        //    //    //        .OnDelete(DeleteBehavior.Restrict); // או NoAction

        //    //    //    modelBuilder.Entity<Match>()
        //    //    //        .HasOne(m => m.Resumefile2)
        //    //    //        .WithMany()
        //    //    //        .OnDelete(DeleteBehavior.Restrict); // או NoAction
        //    //    //}

        //    //    //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //    //    //{
        //    //    //    // Configuring User entity
        //    //    //    modelBuilder.Entity<User>()
        //    //    //        .HasKey(u => u.UserID);

        //    //    //    // Configuring ResumeFile entity
        //    //    //    modelBuilder.Entity<ResumeFile>()
        //    //    //        .HasKey(r => r.ResumeFileID);

        //    //    //    // Configuring Sharing entity
        //    //    //    modelBuilder.Entity<Sharing>()
        //    //    //        .HasKey(s => s.ShareID);

        //    //    //    // Configuring Match entity
        //    //    //    modelBuilder.Entity<Match>()
        //    //    //        .HasKey(m => m.MatchID);

        //    //    //    // Configuring relationships
        //    //    //    modelBuilder.Entity<ResumeFile>()
        //    //    //        .HasOne<Sharing>()
        //    //    //        .WithMany()
        //    //    //        .HasForeignKey(s => s.ResumeFileID);

        //    //    //    modelBuilder.Entity<Sharing>()
        //    //    //        .HasOne(s => s.SharedWithUser)
        //    //    //        .WithMany()
        //    //    //        .HasForeignKey(s => s.SharedWithUserID);

        //    //    //    modelBuilder.Entity<Match>()
        //    //    //        .HasOne(m => m.Resumefile1)
        //    //    //        .WithMany()
        //    //    //        .HasForeignKey(m => m.ResumefileID1);

        //    //    //    modelBuilder.Entity<Match>()
        //    //    //        .HasOne(m => m.Resumefile2)
        //    //    //        .WithMany()
        //    //    //        .HasForeignKey(m => m.ResumefileID2);
        //    //    //}
        //}
    }
}
