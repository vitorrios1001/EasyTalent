using apiEasyTalent.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace apiEasyTalent.Data.EntityConfiguration
{
    public class TalentEntityConfiguration : IEntityTypeConfiguration<Talent>
    {
        public void Configure(EntityTypeBuilder<Talent> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).IsRequired();

            builder.Property(c => c.Name).IsRequired();

            builder.Property(c => c.Skype).IsRequired();

            builder.Property(c => c.Telephone).IsRequired();

            builder.Property(c => c.State).IsRequired();

            builder.Property(c => c.City).IsRequired();

            builder.Property(c => c.Portfolio).IsRequired();

            builder.Property(c => c.HourAtFour).IsRequired();

            builder.Property(c => c.HourFourAtSix).IsRequired();

            builder.Property(c => c.HourSixAtEigth).IsRequired();

            builder.Property(c => c.HourUpEigth).IsRequired();

            builder.Property(c => c.HourOnlyWeekend).IsRequired();

            builder.Property(c => c.Bank).IsRequired();

            builder.Property(c => c.BankAgency).IsRequired();

            builder.Property(c => c.BankCpf).IsRequired();

            builder.Property(c => c.BankNameBank).IsRequired();

            builder.Property(c => c.BankNameTalent).IsRequired();

            builder.Property(c => c.BankNumberAccount).IsRequired();

            builder.Property(c => c.BankTypeChain).IsRequired();

            builder.Property(c => c.BankTypeSavings).IsRequired();

            builder.Property(c => c.Linkedin).IsRequired();

            builder.Property(c => c.PeriodMorning).IsRequired();

            builder.Property(c => c.PeriodAfternoon).IsRequired();

            builder.Property(c => c.PeriodNigth).IsRequired();

            builder.Property(c => c.PeriodDawn).IsRequired();

            builder.Property(c => c.PeriodBusiness).IsRequired();

            builder.Property(c => c.PriceHour).IsRequired();

            builder.ToTable("Talent");

        }
    }
}