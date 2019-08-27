using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    [Table("tblLoginPanel")]
   public class MemberSchool
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Log { get; set; }
        [Required]
        public string Pass { get; set; }
        da

    }
}
