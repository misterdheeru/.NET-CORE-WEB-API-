namespace EMP_CRUD.Models
{
    public interface IEmployee
    {
        List<EMPLOYEES> Display();

        EMPLOYEES UpdateEmployee(int id, EMPLOYEES Data);

        EMPLOYEES DeleteEmployee(int id);

        void InsertEmployee(EMPLOYEES Data);

    }
}
