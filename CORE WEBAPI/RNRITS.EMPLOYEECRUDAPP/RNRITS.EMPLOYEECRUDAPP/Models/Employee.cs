using RNRITS.EMPLOYEECRUDAPP.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RNRITS.EMPLOYEECRUDAPP.Models

{
    [Table("EMPLOYEE")]
    public class Employee
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Column("FirstName")]
        public string FirstName { get; set; }

        [Column("LastName")]
        public string LastName { get; set; }

        [Column("Mobile")]
        public string Mobile { get; set; }

        [Column("Email")]
        public string Email { get; set; }

        [Column("Salary")]
        public double salary { get; set; }

        [Column("Gender")]
        public string Gender { get; set; }

        [Column("HIgherDate")]
        public DateTime HigherDate { get; set; }

        [Column("DOB")]
        public DateTime DOB { get; set; }


        [Column("PID")]
        public int PID { get; set; }

        [ForeignKey("PID")]
        public Positions Position { get; set; }


        //[Column("DEPTID")]
        //public int DEPTID { get; set; }

        //[ForeignKey("DEPTID")]
        //public DEPARTMENT Department { get; set; }

    }
}
