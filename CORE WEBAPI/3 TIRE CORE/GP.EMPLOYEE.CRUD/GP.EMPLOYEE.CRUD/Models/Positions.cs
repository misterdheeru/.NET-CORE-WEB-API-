using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GP.EMPLOYEE.CRUD.Models
{

    [Table("Positions")]
    public class Positions
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        [Key]

        [Column("POSID")]
        public int posID { get; set; }

        [Column("POSNAME")]
        public string posName { get; set; }

        public ICollection<Employees> employees { get; set; }



    }
}
