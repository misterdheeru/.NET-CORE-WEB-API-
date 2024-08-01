using System.ComponentModel.DataAnnotations.Schema;

namespace GP.EMPLOYEE.CRUD.Models
{


    [Table("Employees")]
    public class Employees
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        [Column("Empno")]
        public int Id { get; set; }

        [Column("EmpName")]
        public string name { get; set; }

        [Column("EmpSal")]
        public double sal { get; set; }

        [Column("EmpEmal")]
        public string  email { get; set; }

        [Column("CID")]

        public int companyID { get; set; }
        public Company company { get; set; }

        [Column("POSID")]

        public int posID { get; set; }
        public Positions Positions { get; set; }
    }
}
