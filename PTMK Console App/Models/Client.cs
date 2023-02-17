using PTMKConsoleApp.Utils;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PTMKConsoleApp.Models
{
    [Table("clients")]
    public class Client
    {
        [Key]
        [Column("id")]
        public int ID { get; set; }
        [Required]
        [Column("fullname")]
        public string FullName { get; set; } = null!;
        [Column("date_of_birth")]
        public DateTime DateOfBirth { get; set; }
        [Column("sex")]
        public Sex Sex { get; set; }

        public Client() { }

        public Client(string fullName, DateTime dateOfBirth, Sex sex)
        {
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            Sex = sex;
        }
    }
}