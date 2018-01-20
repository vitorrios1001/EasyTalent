namespace apiEasyTalent.Models
{
    public class Skill
    {
        public int Id { get; set; }

        public int TalentId { get; set; }

        public Talent Talent { get; set; }
        
        public int Ionic { get; set; }

        public int Android { get; set; }

        public int Ios { get; set; }

        public int? Html { get; set; }

        public int? Css { get; set; }

        public int Bootstrap { get; set; }

        public int Jquery { get; set; }

        public int AngularJs { get; set; }

        public int? Java { get; set; }

        public int AspNetMVC { get; set; }

        public int? C { get; set; }

        public int? Cpp { get; set; }

        public int? Cake { get; set; }

        public int? Django { get; set; }

        public int? Majento { get; set; }

        public int Php { get; set; }

        public int? Phyton { get; set; }

        public int Wordpress { get; set; }

        public int? Ruby { get; set; }

        public int? MySQLServer { get; set; }

        public int? MySQL { get; set; }

        public int? Salesforce { get; set; }

        public int? Photoshop { get; set; }

        public int? Illustrator { get; set; }

        public int? SEO { get; set; }

        public string Outros { get; set; }

    }
}