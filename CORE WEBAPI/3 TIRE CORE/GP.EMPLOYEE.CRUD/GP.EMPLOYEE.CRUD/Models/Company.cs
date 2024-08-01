using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GP.EMPLOYEE.CRUD.Models
{

    [Table("company")]
    public class Company
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        [Key]

        [Column("CID")]
        public int companyID { get; set; }

        [Column("CNAME")]
        public string companyName { get; set; }

        public ICollection<Employees> employees { get; set; }
    }
}
