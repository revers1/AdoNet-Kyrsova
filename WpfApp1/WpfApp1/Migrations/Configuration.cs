namespace WpfApp1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WpfApp1.Contextik>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WpfApp1.Contextik context)
        {
            
                context.DbMemberSchool.AddOrUpdate(new MemberSchool() { Id = 1, Log="Student",Pass="s228" });
                context.DbMemberSchool.AddOrUpdate(new MemberSchool() { Id = 1, Log = "Teacher", Pass = "Master" });
                context.DbMemberSchool.AddOrUpdate(new MemberSchool() { Id = 1, Log = "Admin", Pass = "Adminus" });

        }
    }
}
