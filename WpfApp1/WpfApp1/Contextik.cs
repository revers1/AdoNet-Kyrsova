using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Contextik:DbContext
    {
        public Contextik():base("Constring")
        {
                
        }
        public DbSet<Answers> DbAnswers { get; set; }
        public DbSet<Questions> DbQuestions { get; set; }
        public DbSet<MemberSchool> DbMemberSchool { get; set; }

    }
}
