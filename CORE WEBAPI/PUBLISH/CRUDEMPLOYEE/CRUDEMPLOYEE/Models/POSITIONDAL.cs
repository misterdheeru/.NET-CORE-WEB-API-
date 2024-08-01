
using Microsoft.EntityFrameworkCore;

namespace CRUDEMPLOYEE.Models
{
    public class POSITIONDAL : IPOSITION
    {
        private readonly DataContext _dataContext;
        public POSITIONDAL(DataContext datacontext)
        {
            _dataContext  = datacontext;
        }
        public List<POSITION> DisplayPosition()
        {
            var DATA = _dataContext.position.ToList();

            return DATA;
        }

        public void InsertPosition(selectposition position)
        {
            var pos = new POSITION
            {
                PID = position.PID,
                PNAME = position.PNAME,
            };

            _dataContext.position.Add(pos);
            _dataContext.SaveChanges();
        }

    }
}

