using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginPageAbhi.Models
{
    public class StudentLogin
    {
        [Key]
        public int RollNum { get; set; }
        [Required]
        [Column("Enter_Name", TypeName ="varchar(30)")]
        public string? Name{ get; set; }
        [Required]
        [Column("Enter_Email", TypeName = "varchar(30)")]
        public string? Email { get; set; }
        [Required]
        [Column("Enter_Password", TypeName = "varchar(30)")]
        public string? Password { get; set; }


    }
}
