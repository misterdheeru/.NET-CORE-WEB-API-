using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMP_CRUD.Models
{
    [Table("EMPLOYEE")]
    public class EMPLOYEES
    {
        [Key]

        public int empid { set; get; }
        public string empn { set; get; }

        public string empfname { set; get; }

        public string emplname { set; get; }

        public DateTime emphigherdate { set; get; }

        public double empSal { set; get; }

        public string empEmail { set; get; }

        public string empMobile { set; get; }


        public string empgender { set; get; }

        public DateTime empDob { set; get; }

        public int posid { set; get; }

        public POSITION POSITION { set; get; }

        public int deptId { set; get; }


        public DEPARTMENT DEPARTMENT { set; get; }
    }
}
