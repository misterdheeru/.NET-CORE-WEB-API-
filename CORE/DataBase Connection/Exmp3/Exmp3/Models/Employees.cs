using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exmp3.Models
{

    [Table("Employess")]
    public class Employees
    {
        [Key]

        public int Id { get; set; }
        public string Name { get; set; }

        public string Gmail { get; set; }
        public string Address { get; set; }

        public string Gender { get; set; }

        public decimal Salary { get; set; }
    }
}
