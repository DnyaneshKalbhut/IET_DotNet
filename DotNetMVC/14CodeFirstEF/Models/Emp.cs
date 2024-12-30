using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _14CodeFirstEF.Models
{
    [Table("Employee")]

    public class Emp
    {
        [Key]
        [Column("EId",TypeName ="int")]
        public int EId { get; set; }

        [Column("EName",TypeName ="varchar(50)")]
        public string EName { get; set; }

        [Column("EAdress" , TypeName ="varchar(50)")]
        public string EAddress { get; set; }
        [Column("ESalary",TypeName ="int")]
        public decimal ESalary { get; set; } 

    }
}
