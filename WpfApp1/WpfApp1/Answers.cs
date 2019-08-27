using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    [Table("tblAnswers")]
    public class Answers
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Answer{ get; set; }
        [Required]
        public bool IsCorrect { get; set; }

        [Required][ForeignKey("Questionss")]
        public  int Id_Question { get; set; }
        public virtual Questions Questionss { get; set; }

    }
}
