using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;

namespace CRUDEMPLOYEE.Models
{
    public class SQLDAL : IEmployees
    {
        private readonly DataContext _context;
        public SQLDAL(DataContext context)
        {
            _context = context;
        }

       
        public void DeleteEmployee(int id)
        {
          var emp =   _context.employee.Find(id);
            if (emp != null)
            {
                _context.employee.Remove(emp);
                 _context.SaveChanges();
            }

            

        }

       

        public List<selectemp> DisplayEmployee()
        {
            var Data = _context.employee.Include(s => s.Position)
                .Select(Employee => new selectemp
                {
                    ID = Employee.ID,
                    FirstName = Employee.FirstName,
                    LastName = Employee.LastName,
                    Gender = Employee.Gender,
                    HigherDate   =  Employee.HigherDate,
                    DOB = Employee.DOB,
                    Mobile = Employee.Mobile,
                    Email = Employee.Email,
                    salary= Employee.salary,
                    PID = Employee.PID,
                    PNAME = Employee.Position.PNAME
                }).ToList();

            return Data;
        }

  
        public void  InsertEmployeeRecord(selectemp employeeRequest)
        {
            var employee = new Employee
            {
                ID =  employeeRequest.ID,
                FirstName = employeeRequest.FirstName,
                LastName = employeeRequest.LastName,
                Mobile = employeeRequest.Mobile,
                HigherDate = employeeRequest.HigherDate,
                DOB = employeeRequest.DOB,
                Email = employeeRequest.Email,
                salary = employeeRequest.salary,
                Gender = employeeRequest.Gender,
                PID = employeeRequest.PID
              
            };

            _context.employee.Add(employee);
             _context.SaveChanges();
        }

    

        public void UpdateEmployeeRecord(selectemp employeeRequest)
        {
            var emp = _context.employee.FirstOrDefault(s => s.ID == employeeRequest.ID);

            if (emp != null)
            {
                emp.FirstName = employeeRequest.FirstName;
                emp.LastName = employeeRequest.LastName;
                emp.Mobile = employeeRequest.Mobile;
                emp.HigherDate = employeeRequest.HigherDate;
                emp.DOB = employeeRequest.DOB;
                emp.Email = employeeRequest.Email;
                emp.salary = employeeRequest.salary;
                emp.Gender = employeeRequest.Gender;
                emp.PID = employeeRequest.PID;

                _context.SaveChanges();

            }

        }
        public List<selectemp> SearchEmployeeByName(string name)
        {
            var data = _context.employee.Include(s => s.Position)
                .Where(e => EF.Functions.Like((e.FirstName + " " + e.LastName).ToLower(), "%" + name.ToLower() + "%"))
               
                .Select(employee => new selectemp
                {
                    ID = employee.ID,
                    FirstName = employee.FirstName,
                    LastName = employee.LastName,
                    Gender = employee.Gender,
                    HigherDate = employee.HigherDate,
                    DOB = employee.DOB,
                    Mobile = employee.Mobile,
                    Email = employee.Email,
                    salary = employee.salary,
                    PID = employee.PID,
                    PNAME = employee.Position.PNAME
                }).ToList();

            return data;
        }
     

    }
}
