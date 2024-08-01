using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CRUDEMPLOYEE.Models
{
    [Table("POSITION")]
    public class POSITION
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int PID { get; set; }

        [Column("PNAME")]
        public string PNAME { get; set; }
        [JsonIgnore]
        public ICollection<Employee> Employees { get; set; }

    }
}
