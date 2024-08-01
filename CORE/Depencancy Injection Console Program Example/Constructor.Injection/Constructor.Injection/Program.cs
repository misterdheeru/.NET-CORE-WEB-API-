using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Constructor.Employees.Properties;

namespace Constructor.Injection
 {

    public interface IEmployee
    {

        void DisplayEmpInfo();

    }
    public class EmployesinformationData : IEmployee
    {
        public void DisplayEmpInfo( )
        {

            Properties Data = new Properties
            {
                ID = 15456987,
                Name = "Kamagani Tarun",
                MobileNumber = 654879541,
                GmailAddress = "kamaganitarun@gmail.com",
                Address = "Ammerpate",
                Location = "Hydrabad"
            };

            Console.WriteLine($"\n ID = {Data.ID} \n Name = {Data.Name} \n MobileNumber = {Data.MobileNumber } \n Gmail = {Data.GmailAddress} ");

        }
    }
    //public class Office
    //{
    //    private IEmployee da;

    //    public Office(IEmployee da)
    //    {
    //        this.da = da;   
    //    }
    //    public void ShowEMployess()
    //    {
    //        da.DisplayEmpInfo( );
    //    }
        
    //}


    internal class Program 
    {
        private IEmployee da;

        public Program(IEmployee da)
        {
            this.da = da;
        }
        public void ShowEMployess()
        {
            da.DisplayEmpInfo();
        }
        static void Main(string[] args)
        {

 

            IEmployee data = new EmployesinformationData();

            Program da = new Program(data);
            da.ShowEMployess();
        }
    }
}
