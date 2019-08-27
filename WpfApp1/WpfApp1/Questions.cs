using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{

    [Table("tblCreateExam")]
    public class Questions
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Quastion { get; set; }
        [Required]
        public int Price_Q { get; set; }

        public virtual ICollection<Answers> Answerss { get; set; }
       





    }
    
}
