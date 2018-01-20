using apiEasyTalent.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace apiEasyTalent.Data.EntityConfiguration
{
    public class SkillEntityConfiguration : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).IsRequired();

            builder.Property(c => c.Android).IsRequired();

            builder.Property(c => c.AngularJs).IsRequired();

            builder.Property(c => c.AspNetMVC).IsRequired();

            builder.Property(c => c.Bootstrap).IsRequired();

            builder.Property(c => c.C).IsRequired();

            builder.Property(c => c.Cake).IsRequired();

            builder.Property(c => c.Cpp).IsRequired();

            builder.Property(c => c.Css).IsRequired();

            builder.Property(c => c.Django).IsRequired();

            builder.Property(c => c.Html).IsRequired();

            builder.Property(c => c.Illustrator).IsRequired();

            builder.Property(c => c.Id_Skill).IsRequired();

            builder.Property(c => c.Ionic).IsRequired();

            builder.Property(c => c.Ios).IsRequired();

            builder.Property(c => c.Java).IsRequired();

            builder.Property(c => c.Jquery).IsRequired();

            builder.Property(c => c.Majento).IsRequired();

            builder.Property(c => c.MySQL).IsRequired();

            builder.Property(c => c.MySQLServer).IsRequired();

            builder.Property(c => c.Outros).IsRequired();

            builder.Property(c => c.Photoshop).IsRequired();

            builder.Property(c => c.Php).IsRequired();

            builder.Property(c => c.Phyton).IsRequired();

            builder.Property(c => c.Ruby).IsRequired();

            builder.Property(c => c.Salesforce).IsRequired();

            builder.Property(c => c.SEO).IsRequired();

            builder.Property(c => c.Wordpress).IsRequired();

            builder.ToTable("Skill");
            
        }
    }
}