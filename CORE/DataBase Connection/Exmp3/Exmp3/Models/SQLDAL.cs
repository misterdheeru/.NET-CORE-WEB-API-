namespace Exmp3.Models
{
    public class SQLDAL : ICostomerDAL
    {
        private readonly DataContext _data;

        public SQLDAL(DataContext data)
        {
            _data = data;
        }

        public List<Employees> DisplayListEmp()
        {
            return _data.Employees.ToList();
        }
    }
}
