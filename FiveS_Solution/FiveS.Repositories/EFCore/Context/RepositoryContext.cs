using FiveS.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace FiveS.Repositories.EFCore.Context
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {

        }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Audit> Audits { get; set; }
        public DbSet<AuditAnswers> AuditAnswers { get; set; }
        public DbSet<ControlArea> ControlAreas { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Step> Steps { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Token> Tokens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
