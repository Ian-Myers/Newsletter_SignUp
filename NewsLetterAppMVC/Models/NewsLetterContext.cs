using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NewsLetterAppMVC.Models
{
    public partial class NewsLetterContext : DbContext
    {
        public NewsLetterContext()
        {
        }

        public NewsLetterContext(DbContextOptions<NewsLetterContext> options)
            : base(options)
        {
        }

        // Unable to generate entity type for table 'dbo.SignUps'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=NewsLetter;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {}
    }
}
