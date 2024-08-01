using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RNRITS.IEmployees;

namespace Dependancy.Injection
{
    class Empoyees : IEmployees
    {
        private int ID;
        private string Name;
        private string Mobile;
        private string Email;   

        public Empoyees(int id, string name ,string mobile ,string email) 
        {
            this.ID = id;
            this.Name = name;
            this.Mobile = mobile;
            this.Email = email;

        }
        public void Display()
        {
            Console.WriteLine("EMPLOYEE INFORMATION");
            Console.WriteLine("ID ");
            Console.WriteLine("EMPLOYEE INFORMATION");
            Console.WriteLine("EMPLOYEE INFORMATION");
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
 
        }
    }
}
