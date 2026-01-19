using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstApproachN.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Column("StdName", TypeName ="varchar(30)")]
        public string? Name { get; set; }
        [Column("StdGender", TypeName = "varchar(15)")]
        public string? Gender { get; set; }
        public int Age { get; set; }
        public string? Standard { get; set; }
        public string Fees { get; set; }
    }
}
