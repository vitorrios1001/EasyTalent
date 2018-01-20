using apiEasyTalent.Data.EntityConfiguration;
using apiEasyTalent.Models;
using Microsoft.EntityFrameworkCore;

namespace apiEasyTalent.Data
{
    
    public class EasyTalentDbContext : DbContext
    {
        public EasyTalentDbContext() { }

        public DbSet<Talent> Talent { get; set; }

        public DbSet<Skill> Skill { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Talent>()
                .HasOne(t => t.Skill)
                .WithMany()
                .HasForeignKey(t => t.Id_Skill);

            modelBuilder.Entity<Skill>()
                .HasOne(s => s.Talent)
                .WithMany()
                .HasForeignKey(s => s.Id_Skill);

            modelBuilder.ApplyConfiguration(new TalentEntityConfiguration());

            modelBuilder.ApplyConfiguration(new SkillEntityConfiguration());

            base.OnModelCreating(modelBuilder);

        }

        public static string ConnectionString { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(ConnectionString);

            base.OnConfiguring(optionsBuilder);
        }
                
    }
}