using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODAL
{
    [Table("Employees")]
    internal class Employees
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]   
        public  int empid { get; set; }

        public string Empname { get; set; }

        public double EmpSalePrice { get; set; }
    }
}
