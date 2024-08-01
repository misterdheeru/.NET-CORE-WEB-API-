namespace CRUDEMPLOYEE.Models
{
    public interface IEmployees
    {
        List<selectemp> DisplayEmployee();

        void InsertEmployeeRecord(selectemp record);

        void DeleteEmployee(int id); 

        void UpdateEmployeeRecord(selectemp record);

        List<selectemp> SearchEmployeeByName(string name);
    } 
}
