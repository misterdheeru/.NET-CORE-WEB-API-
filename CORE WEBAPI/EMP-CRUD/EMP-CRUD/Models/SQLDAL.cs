
namespace EMP_CRUD.Models
{
    public class SQLDAL : IEmployee
    {
        private readonly DataContext _datacontext;

        public SQLDAL(DataContext _datacontext)
        {
            this._datacontext = _datacontext;
        }
   

        public List<EMPLOYEES> Display()
        {
           return _datacontext.employee.ToList();
        }

        public void InsertEmployee(EMPLOYEES Employee)
        {
            throw new NotImplementedException();
        }

        public EMPLOYEES UpdateEmployee(int id, EMPLOYEES Data)
        {
            throw new NotImplementedException();
        }

        public EMPLOYEES DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }
    }
}
