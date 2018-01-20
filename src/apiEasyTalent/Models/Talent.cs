namespace apiEasyTalent.Models
{
    public class Talent
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Skype { get; set; }

        public string Telephone { get; set; }

        public string Linkedin { get; set; }

        public string City { get; set; }    

        public string State { get; set; }

        public string Portfolio { get; set; }

        public bool HourAtFour { get; set; }

        public bool HourFourAtSix { get; set; }

        public bool HourSixAtEigth { get; set; }

        public bool HourUpEigth { get; set; }

        public bool HourOnlyWeekend { get; set; }

        public bool PeriodMorning { get; set; }

        public bool PeriodAfternoon { get; set; }

        public bool PeriodNigth { get; set; }

        public bool PeriodDawn { get; set; }

        public bool PeriodBusiness { get; set; }

        public int PriceHour { get; set; }

        public string Bank { get; set; }

        public string BankNameBank { get; set; }

        public string BankNameTalent { get; set; }

        public string BankCpf { get; set; }

        public string BankAgency { get; set; }
 
        public bool BankTypeChain { get; set; }

        public bool BankTypeSavings { get; set; }

        public string BankNumberAccount { get; set; }

        public string LinkCrud { get; set; }

        public virtual Skill Skill { get; set; } 

        public int Id_Skill { get; set; } 


    }
}