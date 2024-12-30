
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _34EntityFramework.Model
{

    [Table("Employee")]
    public class Employee
    {
        [Key]
        [Column("Eid",TypeName="int")]
        public int Id { get; set; }

        [Column("Name",TypeName ="varchar(50)")]
        public string Name { get; set; }
        
        [Column("Address", TypeName = "varchar(50)")]
        public string Address { get; set; }
    }
}
