using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMP_CRUD.Models
{
    [Table("DEPARTMENT")]
    public class DEPARTMENT
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int deptId { set; get; }

        public string deptName { set; get; }

        public ICollection<EMPLOYEES> EMPLOYEE { set; get; }
    }
}
